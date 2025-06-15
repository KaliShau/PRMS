using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.LK;

namespace PRMS
{
    public partial class LKForm : Form
    {
        LKController _controller;
        DataTable user;
        public LKForm(DataTable dt)
        {
            InitializeComponent();
            user = dt;

            _controller = new LKController();
            _controller.init(guna2TextBox1, guna2TextBox2, guna2TextBox3, user, label4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.update(guna2TextBox1, guna2TextBox2, guna2TextBox3, user);
        }
    }
}
