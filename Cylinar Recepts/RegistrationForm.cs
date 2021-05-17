using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceptDb;

namespace Cylinar_Recepts
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            enterBtn.Enabled = false;
            regBtn.Enabled = false;

            using (var context = new ReceptContext())
            {
                var login = loginTextBox.Text.Trim();
                var password = passTextBox.Text.Trim();


                if (String.IsNullOrWhiteSpace(login) || String.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Заповніть всі поля");
                }
                else
                {
                    var user = context.Users.AsNoTracking().Where(u => u.Login == login).FirstOrDefault();

                    if (user == null)
                    {
                        context.Users.Add(new User()
                        {
                            Login = login,
                            Password = password
                        });
                        context.SaveChanges();

                        MessageBox.Show("Користувача зареєстровано");

                        EnterForm enterForm = new EnterForm();
                        enterForm.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Користувач з даним логіном зареєстрований");
                    }
                }
            }

            enterBtn.Enabled = true;
            regBtn.Enabled = true;

        }
        
        private void enterBtn_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.Show();
            Close();
        }
    }
}
