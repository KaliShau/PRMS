using System.Data;
using Guna.UI2.WinForms;

namespace PRMS.src.modules.AllRecords
{
    public class AllRecordsController
    {
        public AllRecordsController() { }

        public void init(Guna2DataGridView grid)
        {
            DB db = new DB();
            DataTable dataTable = new DataTable();
            dataTable = db.getData("SELECT id as ID, created_at as \"Дата записи\", \"FIO\" as ФИО, record_type as \"Тип записи\", address as Адрес, content as Содержимое, \"userId\" as \"ID Врача\" FROM \"Patient\"");
            grid.DataSource = dataTable;
        }

        public void search(Guna2TextBox searchField, Guna2DataGridView grid)
        {
            string keyword = searchField.Text;
            DB db = new DB();
            DataTable dt = new DataTable();

            if (keyword == "")
            {
                dt = db.getData("SELECT id as ID, created_at as \"Дата записи\", \"FIO\" as ФИО, record_type as \"Тип записи\", address as Адрес, content as Содержимое, \"userId\" as \"ID Врача\" FROM \"Patient\"");
                grid.DataSource = dt;
                return;
            }

            dt = db.getSearchPatient(keyword);
            grid.DataSource = dt;
        }
    }
}
