using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.Register
{
    public class RegisterController
    {
        public RegisterController() { }

        public void init(ref DataTable department, Guna2ComboBox guna2ComboBox1)
        {
            DB db = new DB();
            DataTable dt = new DataTable();

            List<string> departmentList = new List<string>();

            dt = db.getData("SELECT * FROM \"Department\"");
            department = dt;

            foreach (DataRow row in dt.Rows)
            {
                departmentList.Add(row["name"].ToString());
            }

            foreach (string departmen in departmentList)
            {
                guna2ComboBox1.Items.Add(departmen);
            }
        }

        public void register(TextBox LoginField, TextBox PasswordField, TextBox NameField, Guna2ComboBox guna2ComboBox1, Panel panel1, Panel panel2, Panel panel3, Panel panel4, DataTable department, Form form, Label errorMessage)
        {
            string login = LoginField.Text;
            string pass = PasswordField.Text;
            string name = NameField.Text;

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

            if (NameField.Text == "")
            {
                panel3.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel3.BackColor = Color.White;

            }

            if (guna2ComboBox1.Text == "")
            {
                panel4.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel4.BackColor = Color.White;
            }

            if (login == "" || pass == "" || name == "" || guna2ComboBox1.Text == "")
            {
                return;
            }

            string nameToFind = guna2ComboBox1.Text;
            DataRow[] foundRows = department.Select("name = '" + nameToFind + "'");
            int departamentId = Convert.ToInt32(foundRows[0]["id"]);

            DB db = new DB();
            DataTable dt = new DataTable();

            dt = db.register(login, pass, name, departamentId);

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

        public void OpenLoginForm(Form form)
        {
            Form fomrLogin = new LoginForm();
            fomrLogin.Show();
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
