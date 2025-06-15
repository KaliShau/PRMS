using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.AddRecord
{
    public class AddRecordController
    {
        public AddRecordController() { }

        public void CreateRecord(Guna2TextBox guna2TextBox1, Guna2TextBox guna2TextBox2, Guna2TextBox guna2TextBox3, RichTextBox richTextBox1, Panel panel3, int userId, int departmentId)
        {
            string fio = guna2TextBox1.Text;
            string record = guna2TextBox2.Text;
            string address = guna2TextBox3.Text;
            string content = richTextBox1.Text;

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
                panel3.BackColor = Color.FromArgb(255, 155, 155);

            }

            if (fio == "" || record == "" || address == "" || content == "")
            {
                return;
            }

            DB db = new DB();
            db.createPatient(userId, fio, record, address, content, departmentId);
        }
    }
}
