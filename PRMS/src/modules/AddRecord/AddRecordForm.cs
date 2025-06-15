using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.AddRecord;

namespace PRMS
{
    public partial class AddRecordForm : Form
    {
        AddRecordController _controller;
        int userId;
        int departamentId;
        public AddRecordForm(DataTable user)
        {
            InitializeComponent();
            this.userId = Convert.ToInt16(user.Rows[0]["id"]);
            this.departamentId = Convert.ToInt16(user.Rows[0]["departmentId"]);
            _controller = new AddRecordController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.CreateRecord(guna2TextBox1, guna2TextBox2, guna2TextBox3, richTextBox1, panel3, userId, departamentId);

            panel1.Visible = false;
            panel2.Visible = false;
            label5.Visible = true;
        }

    }
}
