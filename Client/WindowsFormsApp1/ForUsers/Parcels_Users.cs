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
    public partial class Parcels_Users : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();
        string login;

        public Parcels_Users(string data)
        {
            InitializeComponent();
            
            login = data;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            var list = client.SelectUserParcels(login);

            DataTable table = new DataTable();
            table.Columns.Add("Номер посылки", typeof(string));
            table.Columns.Add("Описание", typeof(string));
            table.Columns.Add("Номер склада", typeof(string));
            table.Columns.Add("Дата прибытия", typeof(string));

            foreach (var i in list)
            {                               
                 table.Rows.Add(i[0], i[1], i[2], i[3]);
            }
            

            dataGridView1.DataSource = table;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns["Описание"].Width = 310;
            dataGridView1.Columns["Номер склада"].Width = 80;
            dataGridView1.Columns["Дата прибытия"].Width = 105;
        }
      
        

        
    }
}
