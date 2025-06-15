using System.Data;
using System.Drawing;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.Departaments
{
    public class DepartmentsController
    {
        public DepartmentsController() { }

        public void init(Guna2DataGridView grid)
        {
            DB db = new DB();
            DataTable departament;
            departament = db.getData("SELECT id as ID, created_at as \"Дата создания\", name as Наименование FROM \"Department\"");
            grid.DataSource = departament;
        }

        public void create(Guna2TextBox guna2TextBox2, Guna2DataGridView grid)
        {
            string name = guna2TextBox2.Text;
            if (name == "")
            {
                guna2TextBox2.BorderColor = Color.Red;
                return;
            }
            else
            {
                guna2TextBox2.BorderColor = Color.FromArgb(213, 218, 223);
            }

            DB db = new DB();
            DataTable departament = new DataTable();
            db.createDepartament(name);

            departament = db.getData("SELECT id as ID, created_at as \"Дата создания\", name as Наименование FROM \"Department\"");
            grid.DataSource = departament;
        }

        public void update(Guna2TextBox guna2TextBox1, int departmentId, Guna2DataGridView grid)
        {
            string name = guna2TextBox1.Text;
            if (name == "")
            {
                guna2TextBox1.BorderColor = Color.Red;
                return;
            }
            else
            {
                guna2TextBox1.BorderColor = Color.FromArgb(213, 218, 223);
            }

            DB db = new DB();
            DataTable departament = new DataTable();
            db.updateDepartament(name, departmentId);

            departament = db.getData("SELECT id as ID, created_at as \"Дата создания\", name as Наименование FROM \"Department\"");
            grid.DataSource = departament;
        }

        public void delete(int departmetnId, Guna2DataGridView grid)
        {
            DB db = new DB();
            DataTable departament = new DataTable();
            db.deleteDepartament(departmetnId);

            departament = db.getData("SELECT id as ID, created_at as \"Дата создания\", name as Наименование FROM \"Department\"");
            grid.DataSource = departament;
        }
    }
}
