using System;
using System.Drawing;
using System.Windows.Forms;
using PRMS.src.modules.Login;
using PRMS.src.shared;

namespace PRMS
{
    public partial class LoginForm : Form
    {
        LoginController _controller;
        TopBar _topBar;
        public LoginForm()
        {
            InitializeComponent();
            _controller = new LoginController();
            _topBar = new TopBar();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _controller.login(LoginField, PasswordField, panel1, panel2, this, errorMessage);
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                panel1.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel1.BackColor = Color.White;

            }
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                panel2.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel2.BackColor = Color.White;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            _controller.OpenRegisterForm(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.OpenHomeForm(this);
        }
    }
}
