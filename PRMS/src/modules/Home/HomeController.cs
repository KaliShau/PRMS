using System;
using System.Data;
using System.Windows.Forms;

namespace PRMS.src.modules.Home
{
    public class HomeController
    {
        public HomeController()
        {

        }

        public void init(DataTable user, Panel panel6, Panel panel8, Panel panel15, Panel panel17, Button ExitButton, Button button1, Button button2, Label sayHiLabel, Panel panel13, Panel panel19)
        {
            if (user.Rows.Count == 0)
            {
                panel6.Visible = false;
                panel8.Visible = false;
                panel15.Visible = false;
                panel17.Visible = false;
                ExitButton.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                bool isAdmin = Convert.ToBoolean(user.Rows[0]["isAdmin"]);

                DB db = new DB();
                DataTable departament = new DataTable();

                departament = db.getCurrentDepartament(Convert.ToInt16(user.Rows[0]["departmentId"]));

                sayHiLabel.Text = "Отделение: " + departament.Rows[0]["name"];

                if (isAdmin == true)
                {
                    panel13.Visible = true;
                    panel19.Visible = true;
                }
            }
        }

        public void Exit(Form form)
        {
            DataTable dt = new DataTable();

            Form homeForm = new HomeForm(dt);
            homeForm.Show();
            form.Hide();
        }

        public void OpenLoginForm(Form form)
        {
            Form formLogin = new LoginForm();
            formLogin.Show();
            form.Hide();
        }

        public void OpenRegisterForm(Form form)
        {
            Form registerForm = new RegisterForm();
            registerForm.Show();
            form.Hide();
        }
    }
}
