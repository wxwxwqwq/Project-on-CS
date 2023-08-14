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
    public partial class Authorization : Form
    {
        WebService1SoapClient client = new WebService1SoapClient();


        public Authorization()
        {
            InitializeComponent();
            LoginField.Text = "Введите номер паспорта";
            PasswordField.Text = "Введите пароль";
            LoginField.ForeColor = Color.Gray;            
            PasswordField.ForeColor = Color.Gray;
        }


        int i = 1;
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (i == 1)
            {
                i = 0;
                MainPanel.Focus();
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        Point StartPoint;

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите номер паспорта")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите номер паспорта";
                LoginField.ForeColor = Color.Gray;
            }
        }


        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Введите пароль")
            {
                PasswordField.Text = "";
                PasswordField.ForeColor = Color.Black;
            }
        }
        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                PasswordField.Text = "Введите пароль";
                PasswordField.ForeColor = Color.Gray;
            }
        }
    }
}
