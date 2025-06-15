using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.MyRecords;

namespace PRMS
{
    public partial class MyRecordsForm : Form
    {
        int userId;
        int patientId;
        MyRecordsController _controller;
        public MyRecordsForm(DataTable user)
        {
            InitializeComponent();
            this.userId = Convert.ToInt16(user.Rows[0]["id"]);
            _controller = new MyRecordsController();
            _controller.init(userId, guna2DataGridView1);
        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel1.Visible = true;
            button2.Visible = true;
            label7.Visible = false;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            try
            {
                patientId = Convert.ToInt32(row.Cells[0].Value);
                guna2TextBox1.Text = row.Cells[2].Value.ToString();
                guna2TextBox2.Text = row.Cells[3].Value.ToString();
                guna2TextBox3.Text = row.Cells[4].Value.ToString();
                guna2TextBox4.Text = row.Cells[5].Value.ToString();

            }
            catch
            {
                panel1.Visible = false;
                button2.Visible = false;
                label7.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.update(patientId, guna2TextBox1, guna2TextBox2, guna2TextBox3, guna2TextBox4, userId, guna2DataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.delete(patientId, guna2DataGridView1, userId, panel1, button2, label7);
        }
    }
}
