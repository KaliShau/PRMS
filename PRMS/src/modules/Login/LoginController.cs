using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PRMS.src.modules.Login
{
    public class LoginController
    {
        public LoginController() { }

        public void login(TextBox LoginField, TextBox PasswordField, Panel panel1, Panel panel2, Form form, Label errorMessage)
        {
            string login = LoginField.Text;
            string Password = PasswordField.Text;

            if (LoginField.Text == "")
            {
                panel1.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel1.BackColor = Color.White;

            }

            if (PasswordField.Text == "")
            {
                panel2.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel2.BackColor = Color.White;

            }

            if (login == "" || Password == "")
            {
                return;
            }

            DB db = new DB();
            DataTable dt = new DataTable();

            dt = db.login(login, Password);

            if (dt.Rows.Count > 0)
            {
                HomeForm homeForm = new HomeForm(dt);
                homeForm.Show();
                form.Close();
            }
            else
            {
                errorMessage.Visible = true;
            }
        }

        public void OpenRegisterForm(Form form)
        {
            Form registerForm = new RegisterForm();
            registerForm.Show();
            form.Hide();
        }

        public void OpenHomeForm(Form form)
        {
            DataTable dataTable = new DataTable();
            Form homeForm = new HomeForm(dataTable);
            homeForm.Show();
            form.Hide();
        }
    }
}
