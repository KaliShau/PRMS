using System;
using System.Data;
using System.Windows.Forms;
using PRMS.src.modules.Home;
using PRMS.src.shared;

namespace PRMS
{
    public partial class HomeForm : Form
    {

        public DataTable user;
        HomeController _controller;
        FormManager _formManager;
        TopBar _topBar;
        SideBar _sideBar;

        public HomeForm(DataTable dt)
        {
            InitializeComponent();
            user = dt;
            _controller = new HomeController();
            _formManager = new FormManager();
            _topBar = new TopBar();
            _sideBar = new SideBar();

            _formManager.openForm(new AllRecordsForm(user), panel3);
            _controller.init(user, panel6, panel8, panel15, panel17, ExitButton, button1, button2, sayHiLabel, panel13, panel19);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            _topBar.Exit();
        }
        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            _topBar.Minimized(this);
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            _topBar.ChangeState(this);
        }

        private void TopBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _topBar.DoubleClick(this);
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            _topBar.MouseDown(this);
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            _topBar.MouseUp();
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            _topBar.MouseMove(this);
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            _controller.Exit(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
                _formManager, panel3, new AllRecordsForm(user), panel5, guna2Button1);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
                _formManager, panel3, new MyRecordsForm(user), panel7, guna2Button2);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
                _formManager, panel3, new AddRecordForm(user), panel9, guna2Button3);

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
                _formManager, panel3, new AdminForm(user), panel14, guna2Button4);
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
               _formManager, panel3, new LKForm(user), panel16, guna2Button5);
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
               _formManager, panel3, new MyDepartamentRecordForm(user), panel18, guna2Button6);
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            _sideBar.Chage(panel5, panel7, panel9, panel14, panel16, panel18, panel20, guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7,
               _formManager, panel3, new DepartmentsForm(user), panel20, guna2Button7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.OpenLoginForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.OpenRegisterForm(this);
        }

    }
}
