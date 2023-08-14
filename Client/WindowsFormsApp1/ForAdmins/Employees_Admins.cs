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
    public partial class Employees_Admins : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();

        public Employees_Admins()
        {
            InitializeComponent();
        }

        private void Employees_Admins_Load(object sender, EventArgs e)
        {
            Reload();
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginField.Text != "" && AdminPassField.Text != "" && AdminPassField.Text == "3434") 
            {
                client.UpdateUser(LoginField.Text);

                Reload();
            }
            else if (LoginField.Text == "" || AdminPassField.Text == "")
                ErrorMess.Text = "Не все поля введены";
            else
                ErrorMess.Text = "Неверный пароль";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (EmpNumField.Text != "" && DelPassField.Text != "" && DelPassField.Text == "3434")
            {
                client.DeleteAdmin(EmpNumField.Text);

                Reload();
            }
            else if (EmpNumField.Text == "" || DelPassField.Text == "")
                ErrorMes2.Text = "Не все поля введены";
            else
                ErrorMes2.Text = "Неверный пароль";
        }
    }
}
