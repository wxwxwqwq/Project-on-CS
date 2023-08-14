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
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
            
            

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            var list = obj.Select();
                       
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(string));
            table.Columns.Add("first name", typeof(string));
            table.Columns.Add("last name", typeof(string));
            table.Columns.Add("role", typeof(string));

            foreach (var i in list)
            {
                table.Rows.Add(i[0], i[1], i[2], i[3]);
            }
            

            dataGridView1.DataSource = table;            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
