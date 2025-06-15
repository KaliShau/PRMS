using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.LK
{
    public class LKController
    {
        public LKController() { }

        public void init(Guna2TextBox guna2TextBox1, Guna2TextBox guna2TextBox2, Guna2TextBox guna2TextBox3, DataTable user, Label label4)
        {
            guna2TextBox1.Text = user.Rows[0]["FIO"].ToString();
            guna2TextBox2.Text = user.Rows[0]["email"].ToString();
            guna2TextBox3.Text = user.Rows[0]["password"].ToString();
            int userId = Convert.ToInt32(user.Rows[0]["id"]);

            DB db = new DB();
            DataTable dtPaient = new DataTable();
            dtPaient = db.getPatientId(userId);

            label4.Text = "Количество моих записей: " + dtPaient.Rows.Count;
        }

        public void update(Guna2TextBox guna2TextBox1, Guna2TextBox guna2TextBox2, Guna2TextBox guna2TextBox3, DataTable user)
        {
            string fio = guna2TextBox1.Text;
            string email = guna2TextBox2.Text;
            string password = guna2TextBox3.Text;

            if (fio == "")
            {
                guna2TextBox1.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (email == "")
            {
                guna2TextBox2.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (password == "")
            {
                guna2TextBox3.BorderColor = Color.FromArgb(255, 155, 155);
            }



            if (fio == "" || email == "" || password == "")
            {
                return;
            }

            DB db = new DB();
            DataTable updateUser;
            int userId = Convert.ToInt32(user.Rows[0]["id"]);

            db.updataUser(userId, fio, email, password);

            updateUser = db.login(email, password);

            guna2TextBox1.Text = updateUser.Rows[0]["FIO"].ToString();
            guna2TextBox2.Text = updateUser.Rows[0]["email"].ToString();
            guna2TextBox3.Text = updateUser.Rows[0]["password"].ToString();

        }
    }
}
