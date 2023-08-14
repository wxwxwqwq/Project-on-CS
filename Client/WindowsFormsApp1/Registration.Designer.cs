namespace WindowsFormsApp1
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ErrorMess = new System.Windows.Forms.Label();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.AdminPassField = new System.Windows.Forms.TextBox();
            this.TipPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(130)))));
            this.toolTip1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolTip1.InitialDelay = 999999999;
            this.toolTip1.ReshowDelay = 100;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Bg5;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.ErrorMess);
            this.MainPanel.Controls.Add(this.SurnameField);
            this.MainPanel.Controls.Add(this.AdminPassField);
            this.MainPanel.Controls.Add(this.TipPanel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.PasswordField);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.RegButton);
            this.MainPanel.Controls.Add(this.NameField);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(518, 576);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.arrow4;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(38, 40);
            this.BackButton.TabIndex = 20;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.MinimizeButton.Location = new System.Drawing.Point(441, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 40);
            this.MinimizeButton.TabIndex = 19;
            this.MinimizeButton.Text = "__";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ErrorMess
            // 
            this.ErrorMess.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Silver;
            this.ErrorMess.Location = new System.Drawing.Point(39, 452);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(440, 45);
            this.ErrorMess.TabIndex = 18;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorMess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ErrorMess_MouseDown);
            this.ErrorMess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ErrorMess_MouseMove);
            // 
            // SurnameField
            // 
            this.SurnameField.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.SurnameField.Location = new System.Drawing.Point(141, 179);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SurnameField.Size = new System.Drawing.Size(236, 27);
            this.SurnameField.TabIndex = 17;
            this.SurnameField.Enter += new System.EventHandler(this.SurnameField_Enter_1);
            this.SurnameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SurnameField_KeyDown);
            this.SurnameField.Leave += new System.EventHandler(this.SurnameField_Leave_1);
            // 
            // AdminPassField
            // 
            this.AdminPassField.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.AdminPassField.Location = new System.Drawing.Point(141, 373);
            this.AdminPassField.Name = "AdminPassField";
            this.AdminPassField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminPassField.Size = new System.Drawing.Size(146, 27);
            this.AdminPassField.TabIndex = 16;
            this.AdminPassField.Enter += new System.EventHandler(this.AdminPassField_Enter_1);
            this.AdminPassField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminPassField_KeyDown);
            this.AdminPassField.Leave += new System.EventHandler(this.AdminPassField_Leave_1);
            // 
            // TipPanel
            // 
            this.TipPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.IconQuestion3;
            this.TipPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TipPanel.Location = new System.Drawing.Point(293, 373);
            this.TipPanel.Name = "TipPanel";
            this.TipPanel.Size = new System.Drawing.Size(22, 22);
            this.TipPanel.TabIndex = 15;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.CloseButton.Location = new System.Drawing.Point(480, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 40);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Х";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.PasswordField.Location = new System.Drawing.Point(141, 289);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(236, 27);
            this.PasswordField.TabIndex = 10;
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordField_KeyDown);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.LoginField.Location = new System.Drawing.Point(141, 234);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(236, 27);
            this.LoginField.TabIndex = 9;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginField_KeyDown);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // RegButton
            // 
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(141, 500);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(236, 38);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(141, 124);
            this.NameField.Name = "NameField";
            this.NameField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameField.Size = new System.Drawing.Size(236, 27);
            this.NameField.TabIndex = 2;
            this.NameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.NameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameField_KeyDown);
            this.NameField.Leave += new System.EventHandler(this.NameField_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 576);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registration_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TipPanel;
        private System.Windows.Forms.TextBox AdminPassField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.Label ErrorMess;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button BackButton;
    }
}