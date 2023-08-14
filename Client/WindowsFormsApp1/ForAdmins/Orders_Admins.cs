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
    public partial class Orders_Admins : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();

        public Orders_Admins()
        {
            InitializeComponent();
        }


        private void ClientNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);

            }
        }

        private void ParcelNum_KeyDown(object sender, KeyEventArgs e)
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



        public void Reload()
        {
            var list = client.SelectLink();

            var list_p = client.SelectParcels();

            foreach (var i in list_p)
            {
                ParcelNum.Items.Add(i[0]);
            }


            List<object> DelList = new List<object>();
            foreach (var i in list)
            {
                foreach (var j in ParcelNum.Items) 
                {
                    if (i[3] == (string)j)
                        DelList.Add(j);
                        
                }
            }

            foreach(var i in DelList)
            {
                ParcelNum.Items.Remove(i);
            }

            DataTable table = new DataTable();
            table.Columns.Add("Номер заказчика", typeof(string));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Номер заказа", typeof(string));
            table.Columns.Add("Описание", typeof(string));
            table.Columns.Add("Номер склада", typeof(string));
            table.Columns.Add("Дата прибытия", typeof(string));

            foreach (var i in list)
            {
                table.Rows.Add(i[0], i[1], i[2], i[3], i[4], i[5], i[6]);
                DelNum.Items.Add(i[3]);               
            }

            dataGridView1.DataSource = table;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns["Номер заказчика"].Width = 80;
            dataGridView1.Columns["Имя"].Width = 70;
            dataGridView1.Columns["Фамилия"].Width = 70;
            dataGridView1.Columns["Номер заказа"].Width = 60;
            dataGridView1.Columns["Описание"].Width = 160;
            dataGridView1.Columns["Номер склада"].Width = 60;
            dataGridView1.Columns["Дата прибытия"].Width = 105;
        }



        private void Orders_Admins_Load(object sender, EventArgs e)
        {
            var list_c = client.Select();
            
            foreach (var i in list_c) 
            {              
                ClientNum.Items.Add(i[0]);
            }           
            
            Reload();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientNum.Text != "" && ParcelNum.Text != "")
            {
                client.InsertLink(ClientNum.Text, ParcelNum.Text);

                ParcelNum.Text = "";
                DelNum.Text = "";
                ClientNum.Text = "";

                ParcelNum.Items.Clear();
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
                client.DeleteLink(DelNum.Text);

                ParcelNum.Text = "";
                DelNum.Text = "";
                ClientNum.Text = "";

                ParcelNum.Items.Clear();
                DelNum.Items.Clear();
                Reload();
            }
            else
                ErrorMes2.Text = "Не введён номер";

            
        }      
    }
}
