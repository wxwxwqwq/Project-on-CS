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
            LoginField.Text = "Введите номер телефона";
            PasswordField.Text = "Введите пароль";
            LoginField.ForeColor = Color.Gray;            
            PasswordField.ForeColor = Color.Gray;

            this.LoginField.AutoSize = false;
            this.LoginField.Size = new Size(236, 33);

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(236, 33);
        }
       



        // Оформление формы и организация функций

        //*************************************************************************************************

        // Функции окна программы

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
            Application.Exit();
        }


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                LogButton_Click(LogButton, null);
                
            }
        }


        private void LoginField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                LogButton_Click(LogButton, null);

            }
        }


        private void PasswordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                LogButton_Click(LogButton, null);

            }
        }



        // Перемещение формы

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

        private void ErrorMess_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        private void ErrorMess_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - StartPoint.X;
                this.Top += e.Y - StartPoint.Y;
            }
        }



        // Отображение подсказок на полях ввода

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите номер телефона")
            {
                LoginField.Text = "+7";
                LoginField.ForeColor = Color.Black;
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "+7" || LoginField.Text == "")
            {                
                LoginField.Text = "Введите номер телефона";
                LoginField.ForeColor = Color.Gray;
            }
        }


        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Введите пароль")
            {
                PasswordField.Text = "";
                this.PasswordField.UseSystemPasswordChar = true;
                PasswordField.ForeColor = Color.Black;
            }
        }
        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                this.PasswordField.UseSystemPasswordChar = false;
                PasswordField.Text = "Введите пароль";
                PasswordField.ForeColor = Color.Gray;
            }

            
        }

        //*************************************************************************************************



        // Задачи формы

        //*************************************************************************************************

        private void LogButton_Click(object sender, EventArgs e)
        {
            ErrorMess.Text = "Обработка...";

            int check = 0;

            if (LoginField.Text != "Введите номер телефона" && PasswordField.Text != "Введите пароль" && LoginField.Text != "+7" && PasswordField.Text != "")
            {
                var ans = client.Authorization(LoginField.Text, PasswordField.Text);               

                if (ans[0] == LoginField.Text)
                {
                    check = 1;
                }

                if (check == 1)
                {
                    ErrorMess.Text = "Авторизация выполнена успешно";
                    
                    if (ans[4] == "2") 
                    {
                        this.Hide();
                        MainMenuForUsers MainForm = new MainMenuForUsers(LoginField.Text);
                        MainForm.Show();
                    }
                    else if(ans[4] == "1")
                    {
                        this.Hide();
                        MainMenuForAdmins MainForm = new MainMenuForAdmins();
                        MainForm.Show();
                    }
                    else
                        ErrorMess.Text = "Во время авторизации произошла ошибка";
                }
                else
                    ErrorMess.Text = "Неверно введены номер телефона или пароль";
                    
            }
            else
            {
                ErrorMess.Text = "Не все необходимые поля заполненны";               
            }
          
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration RegForm = new Registration();
            RegForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordField.Text != "Введите пароль" && PasswordField.Text != "")
            {
                if (this.PasswordField.UseSystemPasswordChar == false)
                    this.PasswordField.UseSystemPasswordChar = true;
                else
                    this.PasswordField.UseSystemPasswordChar = false;
            }
        }









        //*************************************************************************************************
    }
}
