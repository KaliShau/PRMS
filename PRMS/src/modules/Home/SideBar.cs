using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PRMS.src.shared;

namespace PRMS.src.modules.Home
{
    public class SideBar
    {
        Color activeColor = Color.FromArgb(155, 166, 196);
        Color defaultColor = Color.Transparent;

        public void Chage(Panel panel5, Panel panel7, Panel panel9, Panel panel14, Panel panel16, Panel panel18, Panel panel20, Guna2Button guna2Button1,
            Guna2Button guna2Button2, Guna2Button guna2Button3, Guna2Button guna2Button4, Guna2Button guna2Button5, Guna2Button guna2Button6, Guna2Button guna2Button7, FormManager formManager,
            Panel panel3, Form FormActive, Panel activePanel, Guna2Button activeButton)
        {
            panel5.Visible = false;
            panel7.Visible = false;
            panel9.Visible = false;
            panel14.Visible = false;
            panel16.Visible = false;
            panel18.Visible = false;
            panel20.Visible = false;

            guna2Button1.BackColor = defaultColor;
            guna2Button2.BackColor = defaultColor;
            guna2Button3.BackColor = defaultColor;
            guna2Button4.BackColor = defaultColor;
            guna2Button5.BackColor = defaultColor;
            guna2Button6.BackColor = defaultColor;
            guna2Button7.BackColor = defaultColor;

            activePanel.Visible = true;
            activeButton.BackColor = activeColor;

            formManager.openForm(FormActive, panel3);
        }
    }
}
