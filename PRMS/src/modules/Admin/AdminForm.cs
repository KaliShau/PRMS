using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.Admin;

namespace PRMS
{
    public partial class AdminForm : Form
    {
        AdminController _controller;
        int userId;
        public AdminForm(DataTable dt)
        {
            InitializeComponent();
            _controller = new AdminController();
            _controller.init(guna2DataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.update(guna2DataGridView1, userId, guna2TextBox1, guna2TextBox2, guna2TextBox3);
        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            label5.Visible = false;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            try
            {
                userId = Convert.ToInt32(row.Cells[0].Value);
                guna2TextBox1.Text = row.Cells[2].Value.ToString();
                guna2TextBox2.Text = row.Cells[3].Value.ToString();
                guna2TextBox3.Text = row.Cells[4].Value.ToString();

            }
            catch
            {
                panel1.Visible = false;
                panel2.Visible = false;
                label5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.delete(userId, guna2DataGridView1);
        }
    }
}
