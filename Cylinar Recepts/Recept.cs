using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using ReceptDb;

namespace Cylinar_Recepts
{
    public partial class Recept : Form
    {
        
        ReceptDb.Recept currentRecept;

        PrintDialog printDialog;
        PrintDocument printDocument;

        MainForm mainForm;

        public Recept()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ініціалізація форм
        /// </summary>
        /// <param name="s">Кнопка яка викликала відкриття форми</param>
        /// <param name="user">Користувач</param>
        /// <param name="recept">Рецепт для якого відкривається форма</param>
        public Recept(object s, User user, ReceptDb.Recept recept, MainForm main)
        {

            InitializeComponent();
            printDocument = new PrintDocument();
            printDialog = new PrintDialog();
            printDocument.PrintPage += PrintDocument_PrintPage;
            mainForm = main;

            currentRecept = recept;


            if (user.isAdmin)
            {
                receptPrintBtn.Visible = false;

                if (((s is Button) && ((Button)s).Name == "openModerationBtn") 
                    || ((s is ListBox) && ((ListBox)s).Name == "userReceptsListBox"))
                {
                    rejectBtn.Text = "Відхилити";
                    confirmBtn.Visible = true;
                }
                
                rejectBtn.Visible = true;
            }

            receptNameLabel.Text = recept.Name;
            receptTypeLabel.Text = recept.ReceptType.Name;
            descriptionBox.Text = recept.Description;
            receptAurhorLabel.Text = recept.User.Login;

            using (var context = new ReceptContext())
            {
                var rec = recept.Ingredients.Join(
                    context.Units,
                    r => r.UnitId,
                    u => u.id,
                    (r, u)=> new 
                    {
                        Name = r.Name,
                        Count = r.Count,
                        Unit = u.Name
                    });


                ingredientsData.Columns.Add("Name", "Назва");
                ingredientsData.Columns.Add("Count", "Кількість");
                ingredientsData.Columns.Add("Unit", "Мірна одиниця");


                foreach (var ingr in rec.ToList())
                {
                    ingredientsData.Rows.Add(ingr.Name, ingr.Count, ingr.Unit);
                }
            }
        }

       
        //Підтвердження додававння рецепту
        private void confirmBtn_Click(object sender, System.EventArgs e)
        {
            using (var context = new ReceptContext())
            {

                var result = MessageBox.Show("Підтвердити?", "Додавання", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;


                var recept = context.Recepts.Where(r => r.id == currentRecept.id).FirstOrDefault();
                recept.Moderation = true;
                context.SaveChanges();
            }
            mainForm.refreshList();
            Close();
        }
            
        //Видалення-Відхилення рецепту
        private void rejectBtn_Click(object sender, System.EventArgs e)
        {
            using (var context = new ReceptContext())
            {
                var result = MessageBox.Show("Підтвердити?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                var recept = context.Recepts.Where(r => r.id == currentRecept.id).FirstOrDefault();

                context.Recepts.Remove(recept);
                context.SaveChanges();
            }
            mainForm.refreshList();
            Close();
        }

        private void receptPrintBtn_Click(object sender, System.EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        //Друк рецепту
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            using (var context = new ReceptContext())
            {
                var recept = context.Recepts.Where(r => r.id == currentRecept.id).FirstOrDefault();

                string print = recept.Name + "\n\nІнгредієнти\n\n";

                foreach (var ingr in recept.Ingredients.ToList())
                {
                    print += $"{ingr.Name} - {ingr.Count} {ingr.Unit.Name}\n";
                }

                print += "\nРецепт\n\n" + recept.Description;

                e.Graphics.DrawString(print, new Font("Arial", 14), Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            }
        }
    }
}
