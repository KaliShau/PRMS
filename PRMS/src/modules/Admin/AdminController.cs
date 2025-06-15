using System.Data;
using System.Drawing;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.Admin
{
    public class AdminController
    {
        public AdminController() { }

        public void init(Guna2DataGridView grid)
        {
            DB db = new DB();
            DataTable dtUsers;
            dtUsers = db.getData("SELECT id as ID, created_at as \"Дата создания\", \"FIO\" as \"ФИО\", email as \"Логин\", password as \"Пароль\" FROM \"User\" ");
            grid.DataSource = dtUsers;
        }

        public void update(Guna2DataGridView grid, int userId, Guna2TextBox guna2TextBox1, Guna2TextBox guna2TextBox2, Guna2TextBox guna2TextBox3)
        {
            int id = userId;
            string fio = guna2TextBox1.Text;
            string login = guna2TextBox2.Text;
            string password = guna2TextBox3.Text;

            if (fio == "")
            {
                guna2TextBox1.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (login == "")
            {
                guna2TextBox2.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (password == "")
            {
                guna2TextBox3.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (fio == "" || login == "" || password == "")
            {
                return;
            }

            DB db = new DB();
            DataTable dt = new DataTable();
            db.updataUser(id, fio, login, password);

            dt = db.getData("SELECT id as ID, created_at as \"Дата создания\", \"FIO\" as \"ФИО\", email as \"Логин\", password as \"Пароль\" FROM \"User\" ");
            grid.DataSource = dt;
        }

        public void delete(int userId, Guna2DataGridView grid)
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            db.deleteUser(userId);

            dt = db.getData("SELECT id as ID, created_at as \"Дата создания\", \"FIO\" as \"ФИО\", email as \"Логин\", password as \"Пароль\" FROM \"User\" ");
            grid.DataSource = dt;
        }
    }
}
