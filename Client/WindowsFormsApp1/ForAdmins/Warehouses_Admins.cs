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
    public partial class Warehouses_Admins : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();

        public Warehouses_Admins()
        {
            InitializeComponent();
        }


        public void Reload()
        {
            var list = client.SelectWarehouses();

            DataTable table = new DataTable();
            table.Columns.Add("Номер склада", typeof(string));
            table.Columns.Add("Адрес", typeof(string));
            table.Columns.Add("Вместимость", typeof(string));
            table.Columns.Add("Заполненность", typeof(string));

            foreach (var i in list)
            {
                table.Rows.Add(i[0], i[1], i[2], i[3]);
            }


            dataGridView1.DataSource = table;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns["Адрес"].Width = 314;
        }


        private void AddressField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void CapacityField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void Warehouses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void DelNumField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                DelButton_Click(button1, null);

            }
        }


        private void Warehouses_Load(object sender, EventArgs e)
        {
            Reload();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (AddressField.Text != "" && CapacityField.Text != "")
            {
                client.InsertWarehouse(AddressField.Text, CapacityField.Text);

                Reload();
            }
            else
                ErrorMess.Text = "Не все поля введены";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (DelNumField.Text != "")
            {
                client.DeleteWarehouse(DelNumField.Text);
            }
            else
                ErrorMes2.Text = "Не введён номер";

            Reload();
        }

        
    }
}
