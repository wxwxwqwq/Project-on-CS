using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.WebService1;

namespace WindowsFormsApp1
{
    public partial class Warehouses_Users : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();

        public Warehouses_Users()
        {
            InitializeComponent();
        }


        public void Reload()
        {
            var list = client.SelectWarehouses();

            DataTable table = new DataTable();
            table.Columns.Add("Номер склада", typeof(string));
            table.Columns.Add("Адрес", typeof(string));
            

            foreach (var i in list)
            {
                table.Rows.Add(i[0], i[1]);
            }


            dataGridView1.DataSource = table;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns["Адрес"].Width = 314;
        }

        private void Warehouses_Users_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
