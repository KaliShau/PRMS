using System.Windows.Forms;

namespace PRMS.src.shared
{
    public class FormManager
    {
        public Form activeForm = null;

        public void openForm(Form childForm, Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
