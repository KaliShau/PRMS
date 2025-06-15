using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.AllRecords;

namespace PRMS
{
    public partial class AllRecordsForm : Form
    {
        AllRecordsController _controller;
        public AllRecordsForm(DataTable user)
        {
            InitializeComponent();
            _controller = new AllRecordsController();
            _controller.init(guna2DataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.search(searchField, guna2DataGridView1);
        }
    }
}
