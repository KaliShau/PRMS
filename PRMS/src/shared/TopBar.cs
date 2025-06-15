using System.Drawing;
using System.Windows.Forms;

namespace PRMS.src.shared
{
    public class TopBar
    {

        bool dragging = false;
        Point dragCursotPoint;
        Point dragFromPoint;

        public void Exit()
        {
            Application.Exit();
        }

        public void Minimized(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void ChangeState(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                form.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        public void DoubleClick(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                form.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        public void MouseDown(Form form)
        {
            dragging = true;
            dragCursotPoint = Cursor.Position;
            dragFromPoint = form.Location;
        }

        public void MouseUp()
        {
            dragging = false;
        }

        public void MouseMove(Form form)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursotPoint));
                form.Location = Point.Add(dragFromPoint, new Size(dif));
            }
        }
    }
}
