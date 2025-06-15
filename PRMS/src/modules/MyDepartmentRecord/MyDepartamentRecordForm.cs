using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.MyDepartmentRecord;

namespace PRMS
{
    public partial class MyDepartamentRecordForm : Form
    {
        MyDepartmentRecordController _controller;
        public MyDepartamentRecordForm(DataTable user)
        {
            InitializeComponent();
            _controller = new MyDepartmentRecordController();
            _controller.init(user, guna2DataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.search(searchField, guna2DataGridView1);
        }
    }
}
