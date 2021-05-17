using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceptDb;

namespace Cylinar_Recepts
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            enterBtn.Enabled = false;
            registrationBtn.Enabled = false;
            using (var context = new ReceptContext())
            {
                var login = loginTextBox.Text.Trim();
                var password = passwordTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Заповніть всі поля");
                }
                else
                {
                    var user = context.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();

                    if (user != null)
                    {
                        MainForm mainForm = new MainForm(user);
                        mainForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Введені невірні дані входу");
                    }
                }
            }
            registrationBtn.Enabled = true;
            enterBtn.Enabled = true;
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Hide();
        }
    }
}
