using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceptDb;

namespace Cylinar_Recepts
{
    public partial class MainForm : Form
    {
        User user;
        public MainForm()
        {
            InitializeComponent();
        }

        //Загрузка форми
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;

            //Обработчики событий для двойного клика по ListBox
            receptsListBox.DoubleClick += OpenDouble_Click;
            userReceptsListBox.DoubleClick += OpenDouble_Click;

            userReceptsListBox.SelectionMode = SelectionMode.One;
            receptsListBox.SelectionMode = SelectionMode.One;

            LoadIntefaceFor();

            userNameLabel.Text = user.Login;

            using(var context = new ReceptContext())
            {
                var types = context.ReceptTypes.AsNoTracking().ToList();
                var recepts = context.Recepts.AsNoTracking().Where(r => r.Moderation == true).ToList();

                types.Add(new ReceptType() { Name = "Всі", id = 0 });
                
                receptTypesBox.DataSource = types;
                receptTypesBox.ValueMember = "id";
                receptTypesBox.DisplayMember = "Name";

                receptTypesBox.SelectedItem = types.Last();

                receptsListBox.DataSource = recepts;
                receptsListBox.ValueMember = "Id";
                receptsListBox.DisplayMember = "Name";
            }
        }

        //Будування інтерфейу відповідно до користувача
        private void LoadIntefaceFor()
        {
            //Перевірка чи являється користувач адміном
            if (user.isAdmin)
            {
                receptAddBtn.Visible = false;
                receptDeleteBtn.Visible = false;
                receptChangeBtn.Visible = false;
                openModerationBtn.Visible = true;

                using (var context = new ReceptContext())
                {
                    var recepts = context.Recepts.AsNoTracking().Where(r => r.Moderation == false).ToList();
                    userReceptsListBox.DataSource = recepts;
                    userReceptsListBox.ValueMember = "Id";
                    userReceptsListBox.DisplayMember = "Name";
                }

            }
            else
            {
                userReceptsListBox.DataSource = user.Recepts;
                userReceptsListBox.ValueMember = "Id";
                userReceptsListBox.DisplayMember = "Name";
            }
        }

        //Відкриття рецепту по подвійному кліку
        private void OpenDouble_Click(object sender, EventArgs e)
        {
            int id;
            if (((ListBox)sender).Name == "userReceptsListBox") id = (int)userReceptsListBox.SelectedValue;
            else id = (int)receptsListBox.SelectedValue;

            ShowRecept(id, sender);
        }

        //Відкриття рецепту
        private void receptOpenBtn_Click(object sender, EventArgs e)
        {

            if(userReceptsListBox.SelectedItems.Count > 0)
            {
                int id;
                if (((Button)sender).Name == "openModerationBtn") id = (int)userReceptsListBox.SelectedValue;
                else id = (int)receptsListBox.SelectedValue;

                ShowRecept(id, sender);
            }
            
        }

        //Відкриття форми для відображення рецепту
        private void ShowRecept(int id, object sender) 
        {
            using (var contex = new ReceptContext())
            {
                var recept = contex.Recepts.Where(r => r.id == id).FirstOrDefault();

                if (recept != null)
                {
                    Recept receptForm = new Recept(sender, user, recept, this);
                    receptForm.Show();
                }
            }
        }

        //Закриття форми
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();


        //Зміна типу рецепту
        private void receptTypesBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeTypeAsync();

        private async Task ChangeTypeAsync() => await Task.Run(() => ChangeType());

        private void ChangeType()
        {
            if (receptTypesBox.Items.Count > 0)
            {
                using (var context = new ReceptContext())
                {
                    var type = (ReceptType)receptTypesBox.SelectedItem;
                    List<ReceptDb.Recept> recepts;
                    if (type.id != 0)
                        recepts = context.Recepts.AsNoTracking().Where(r => r.ReceptTypeId == type.id && r.Moderation == true).ToList();
                    else
                        recepts = context.Recepts.AsNoTracking().Where(r => r.Moderation == true).ToList();

                    receptsListBox.DataSource = recepts;
                    receptsListBox.ValueMember = "Id";
                    receptsListBox.DisplayMember = "Name";
                }
            }
        }

        //Пошук
        private void findBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(findTextBox.Text))
            {
                var findedRecept = findTextBox.Text;
                var type = (ReceptType)receptTypesBox.SelectedItem;

                using (var context = new ReceptContext())
                {

                    List<ReceptDb.Recept> recepts;

                    if (type.id != 0)
                        recepts = context.Recepts.AsNoTracking()
                                                 .Where(r => r.ReceptTypeId == type.id && r.Name.Contains(findedRecept))
                                                 .ToList();
                    else
                        recepts = context.Recepts.AsNoTracking()
                                                 .Where(r => r.Name.Contains(findedRecept))
                                                 .ToList();

                    if (recepts.Count > 0)
                    {
                        receptsListBox.DataSource = recepts;
                        receptsListBox.ValueMember = "Id";
                        receptsListBox.DisplayMember = "Name";
                    }
                    else
                    {
                        MessageBox.Show("Нічого не знайдено");
                    }
                }
            }

        }

        //Відкриття форми для додавання рецепту
        private void receptAddBtn_Click(object sender, EventArgs e)
        {
            ReceptAdd receptAdd = new ReceptAdd(user);
            receptAdd.Show();
        }

        //Редагування рецепту
        private void receptChangeBtn_Click(object sender, EventArgs e)
        {
            if(userReceptsListBox.SelectedItems.Count > 0)
            {
                var recept = (ReceptDb.Recept)userReceptsListBox.SelectedItem;
                ReceptAdd receptAdd = new ReceptAdd(user, recept.id);
                receptAdd.Show();
            }
        }

        //Видалення рецепту
        private void receptDeleteBtn_Click(object sender, EventArgs e)
        {

            if(userReceptsListBox.SelectedItems.Count > 0)
            {
                var id = (ReceptDb.Recept)userReceptsListBox.SelectedItem;


                using (var context = new ReceptContext())
                {
                    var res = MessageBox.Show("Ви точно хочете видалити?", "Видалити", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.No) return;

                    var recept = context.Recepts.Where(r => r.id == id.id).FirstOrDefault();

                    context.Recepts.Remove(recept);
                    context.SaveChanges();
                }

                refreshUserBtn_Click(this, EventArgs.Empty);

            }

        }

        public void refreshList() => refreshUserBtn_Click(null, EventArgs.Empty);

        //Обновити занчення списку рецептів користувача
        private void refreshUserBtn_Click(object sender, EventArgs e) => refreshUserListAsync();

        private async Task refreshUserListAsync()
        {
            await Task.Run(() => refreshUserList());
        }

        private void refreshUserList()
        {
            using (var context = new ReceptContext())
            {
                List<ReceptDb.Recept> recepts;

                if (user.isAdmin) recepts = context.Recepts
                                                   .Where(r => r.Moderation == false)
                                                   .ToList();
                else recepts = context.Recepts
                                      .Where(r => r.UserId == user.id && r.Moderation == true)
                                      .ToList();


                userReceptsListBox.DataSource = recepts;
                userReceptsListBox.ValueMember = "Id";
                userReceptsListBox.DisplayMember = "Name";
            }
        }

        //Оновити список рецептів Головна
        private void refreshBtn_Click(object sender, EventArgs e) => receptTypesBox_SelectedIndexChanged(this, null);

        private void findTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter) findBtn_Click(null, EventArgs.Empty);
        }
    }
}
