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
    public partial class Parcels_Admins : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();

        public Parcels_Admins()
        {
            InitializeComponent();
            
            this.ParcelNumField.AutoSize = false;
            this.ParcelNumField.Size = new Size(236, 21);

            this.NameField.AutoSize = false;
            this.NameField.Size = new Size(236, 21);
        }


        private void ParcelNumField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void NameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void WarehouseField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void DateField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void DelNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                DelButton_Click(button1, null);

            }

        }


        private void Parcels_Load(object sender, EventArgs e)
        {
            Reload();

            var list = client.SelectWarehouses();

            foreach (var i in list)
            {
                WarehouseField.Items.Add(i[0]);
            }
        }


        public void Reload()
        {
            var list = client.SelectParcels();

            DataTable table = new DataTable();
            table.Columns.Add("Номер посылки", typeof(string));
            table.Columns.Add("Описание", typeof(string));
            table.Columns.Add("Номер склада", typeof(string));
            table.Columns.Add("Дата прибытия", typeof(string));

            foreach (var i in list)
            {
                table.Rows.Add(i[0], i[1], i[2], i[3]);
                DelNum.Items.Add(i[0]);
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (ParcelNumField.Text != "" && WarehouseField.Text != "" && DateField.Value != null && NameField.Text != "")
            {
                client.InsertParcel(ParcelNumField.Text, NameField.Text, WarehouseField.Text, DateField.Value);
                client.AddInWarehouse(WarehouseField.Text);

                ParcelNumField.Text = "";
                NameField.Text = "";
                WarehouseField.Text = "";

                DelNum.Items.Clear();
                Reload();
            }
            else
                ErrorMess.Text = "Не все поля введены";
        }
       
        
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (DelNum.Text != "")
            {
                client.DelInWarehouse(DelNum.Text);
                client.DeleteParcel(DelNum.Text);
                client.DeleteLink(DelNum.Text);


                DelNum.Text = "";

                DelNum.Items.Clear();
                Reload();
            }
            else
                ErrorMes2.Text = "Не введён номер";            
        }       
    }
}
