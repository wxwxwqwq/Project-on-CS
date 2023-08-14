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
    public partial class Admins_Users : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();
        string login;

        public Admins_Users(string data)
        {
            InitializeComponent();

            login = data;
        }


        public void Reload()
        {
            var list = client.SelectAdmins();

            DataTable table = new DataTable();
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Номер телефона", typeof(string));

            foreach (var i in list)
            {
                table.Rows.Add(i[1], i[2], i[0]);
            }


            dataGridView1.DataSource = table;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


        }

        private void Admins_Users_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminPassField.Text != "" && AdminPassField.Text == "3434")
            {
                client.UpdateUser(login);

                Reload();

                ErrorMess.Text = "Подтверждено";
            }
            else if (AdminPassField.Text == "")
                ErrorMess.Text = "Пароль не введён";
            else
                ErrorMess.Text = "Неверный пароль";
        }
    }
}
