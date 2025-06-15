using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PRMS.src.modules.Register;
using PRMS.src.shared;

namespace PRMS
{
    public partial class RegisterForm : Form
    {

        DataTable department;
        RegisterController _controller;
        TopBar _topBar;
        public RegisterForm()
        {
            InitializeComponent();
            _controller = new RegisterController();
            _topBar = new TopBar();

            _controller.init(ref department, guna2ComboBox1);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            _controller.register(LoginField, PasswordField, NameField, guna2ComboBox1, panel1, panel2, panel3, panel4, department, this, errorMessage);
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

        private void NameField_TextChanged(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                panel3.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel3.BackColor = Color.White;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            _controller.OpenLoginForm(this);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void TopBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            _topBar.Exit();
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "")
            {
                panel4.BackColor = Color.FromArgb(255, 155, 155);
            }
            else
            {
                panel4.BackColor = Color.White;

            }
        }
    }
}
