using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PRMS.src.modules.Departaments;

namespace PRMS
{
    public partial class DepartmentsForm : Form
    {
        DepartmentsController _controller;
        int departamentId;
        public DepartmentsForm(DataTable user)
        {
            InitializeComponent();
            _controller = new DepartmentsController();
            _controller.init(guna2DataGridView1);
        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel2.Visible = true;
            if (e.RowIndex == -1) return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            try
            {
                departamentId = Convert.ToInt32(row.Cells[0].Value);
                guna2TextBox1.Text = row.Cells[2].Value.ToString();

            }
            catch
            {
                guna2TextBox1.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.create(guna2TextBox2, guna2DataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.update(guna2TextBox1, departamentId, guna2DataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.delete(departamentId, guna2DataGridView1);
        }
    }
}
