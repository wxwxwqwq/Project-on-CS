using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenuForAdmins : Form
    {
        public MainMenuForAdmins()
        {
            InitializeComponent();
        }



        //Методы для вкладок
        Button PrvSender = new Button();
        private void SelectButton(object btnSender)
        {

            if (PrvSender != (Button)btnSender)
            {
                Return();
                PrvSender = (Button)btnSender;
                PrvSender.BackColor = Color.FromArgb(130, 134, 171);
            }
        }

        
        private void Return()
        {
            foreach (Control Button in panel1.Controls)
            {
                PrvSender.BackColor = Color.FromArgb(37, 41, 61);
            }
        }

        
        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }

            SelectButton(btnSender);

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();

        }



        // Оформление формы и организация функций

        //*************************************************************************************************

        // Функции окна программы

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //Переключение вкладок
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Parcels_Admins(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Warehouses_Admins(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Orders_Admins(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employees_Admins(), sender);
        }



        //Перемещение формы

        Point StartPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }

        private void DesktopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void DesktopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization AutoForm = new Authorization();
            AutoForm.Show();
        }

        //*************************************************************************************************



    }
}
