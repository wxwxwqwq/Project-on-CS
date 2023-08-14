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
    public partial class ParcelsAdd : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();

        public ParcelsAdd()
        {
            InitializeComponent();

            this.ParcelNumField.AutoSize = false;
            this.ParcelNumField.Size = new Size(272, 21);

            this.NameField.AutoSize = false;
            this.NameField.Size = new Size(272, 100);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ParcelsAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
