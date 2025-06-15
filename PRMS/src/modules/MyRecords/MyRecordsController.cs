using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.MyRecords
{
    public class MyRecordsController
    {
        public MyRecordsController() { }

        public void init(int userId, Guna2DataGridView grid)
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            dt = db.getPatientId(userId);
            grid.DataSource = dt;
        }

        public void update(int patientId, Guna2TextBox guna2TextBox1, Guna2TextBox guna2TextBox2, Guna2TextBox guna2TextBox3, Guna2TextBox guna2TextBox4, int userId, Guna2DataGridView grid)
        {
            int id = patientId;
            string fio = guna2TextBox1.Text;
            string record = guna2TextBox2.Text;
            string address = guna2TextBox3.Text;
            string content = guna2TextBox4.Text;

            if (fio == "")
            {
                guna2TextBox1.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (record == "")
            {
                guna2TextBox2.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (address == "")
            {
                guna2TextBox3.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (content == "")
            {
                guna2TextBox4.BorderColor = Color.FromArgb(255, 155, 155);
            }

            if (fio == "" || record == "" || address == "" || content == "")
            {
                return;
            }

            DB db = new DB();
            DataTable dt = new DataTable();
            db.updataPatient(id, fio, record, address, content);

            dt = db.getPatientId(userId);
            grid.DataSource = dt;
        }

        public void delete(int patientId, Guna2DataGridView grid, int userId, Panel panel1, Button button2, Label label7)
        {
            int id = patientId;

            DB db = new DB();
            DataTable dt = new DataTable();
            db.deletePatient(id);

            dt = db.getPatientId(userId);
            grid.DataSource = dt;

            panel1.Visible = false;
            button2.Visible = false;
            label7.Visible = true;
        }
    }
}
