﻿using System;
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
    public partial class Registration : Form
    {
        string tx = "Если Вы являетесь работником организации, \r\nвведите в это поле пароль, выданный " + "начальством, \r\nчтобы активировать дополнительные функции. \r\nЭто поле можно оставить пустым.\r\n";
        WebService1SoapClient client = new WebService1SoapClient();


        public Registration()
        {
            InitializeComponent();
            NameField.Text = "Введите имя";
            NameField.ForeColor = Color.Gray;
            AdminPassField.Text = "Пароль админа";
            AdminPassField.ForeColor = Color.Gray;
            SurnameField.Text = "Введите фамилию";
            SurnameField.ForeColor = Color.Gray;
            LoginField.Text = "Введите номер телефона";
            LoginField.ForeColor = Color.Gray;
            PasswordField.Text = "Введите пароль";
            PasswordField.ForeColor = Color.Gray;

            this.NameField.AutoSize = false;
            this.NameField.Size = new Size(236, 33);

            this.SurnameField.AutoSize = false;
            this.SurnameField.Size = new Size(236, 33);

            this.LoginField.AutoSize = false;
            this.LoginField.Size = new Size(236, 33);

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(236, 33);

            this.AdminPassField.AutoSize = false;
            this.AdminPassField.Size = new Size(146, 33);
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


        private void MainPanel_Click(object sender, EventArgs e)
        {
            MainPanel.Focus();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        //Обработка нажатия Enter

        private void Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                RegButton_Click(RegButton, null);

            }
        }


        private void NameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                RegButton_Click(RegButton, null);

            }
        }


        private void SurnameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                RegButton_Click(RegButton, null);

            }
        }


        private void LoginField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                RegButton_Click(RegButton, null);

            }
        }


        private void PasswordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                RegButton_Click(RegButton, null);

            }
        }


        private void AdminPassField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                RegButton_Click(RegButton, null);

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

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
                
        }        
        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.Gray;
            }
        }


        private void SurnameField_Enter_1(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введите фамилию")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.Black;
            }
                
        }
        private void SurnameField_Leave_1(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Введите фамилию";
                SurnameField.ForeColor = Color.Gray;
            }
        }


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


        private void AdminPassField_Enter_1(object sender, EventArgs e)
        {
            toolTip1.Show(tx, TipPanel);
            if (AdminPassField.Text == "Пароль админа")
            {
                AdminPassField.Text = "";
                AdminPassField.ForeColor = Color.Black;
            }
        }
        private void AdminPassField_Leave_1(object sender, EventArgs e)
        {
            if (AdminPassField.Text == "")
            {
                AdminPassField.Text = "Пароль админа";
                AdminPassField.ForeColor = Color.Gray;
            }
            toolTip1.Hide(TipPanel);
        }

        //*************************************************************************************************



        // Задачи формы

        //*************************************************************************************************

        private void RegButton_Click(object sender, EventArgs e)
        {
            ErrorMess.Text = "Обработка...";
            
            var list_of_users = client.Select();
            int check = 1;

            foreach (var i in list_of_users)
            {
                if (i[0] == LoginField.Text)
                {                   
                    check = 0;
                    break;
                }
            }


            if (NameField.Text != "Введите имя" && SurnameField.Text != "Введите фамилию" && LoginField.Text != "Введите номер телефона" && PasswordField.Text != "Введите пароль" && check == 1 && NameField.Text != "" && SurnameField.Text != "" && LoginField.Text != "+7" && PasswordField.Text != "")
            {              
                string role = "2";
                if (AdminPassField.Text == "3434")
                {
                    role = "1";
                }
                else if (AdminPassField.Text != "Пароль админа")
                    ErrorMess.Text = "Введён неверный пароль организации";

                int ans = client.Registration(LoginField.Text, PasswordField.Text, NameField.Text, SurnameField.Text, role);

                this.Hide();
                Authorization AutoForm = new Authorization();
                AutoForm.Show();
                                
            }
            else if (check == 1)
                ErrorMess.Text = "Не все необходимые поля заполненны";
            else if (check == 0)
                ErrorMess.Text = "Человек с таким номером уже зарегистрирован";

        }

        

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization AutoForm = new Authorization();
            AutoForm.Show();
        }



        //*************************************************************************************************







    }
}
