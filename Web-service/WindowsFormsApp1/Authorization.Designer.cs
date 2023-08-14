namespace WindowsFormsApp1
{
    partial class Authorization
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
            this.RegButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ErrorMess = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.LoginField = new System.Windows.Forms.TextBox();
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
            this.MainPanel.Controls.Add(this.RegButton);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.ErrorMess);
            this.MainPanel.Controls.Add(this.PasswordField);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.LogButton);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(502, 427);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // RegButton
            // 
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(141, 348);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(236, 38);
            this.RegButton.TabIndex = 20;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
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
            this.MinimizeButton.Location = new System.Drawing.Point(425, 0);
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
            this.ErrorMess.Location = new System.Drawing.Point(39, 245);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(440, 45);
            this.ErrorMess.TabIndex = 18;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(141, 179);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordField.Size = new System.Drawing.Size(236, 33);
            this.PasswordField.TabIndex = 17;
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
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
            this.CloseButton.Location = new System.Drawing.Point(464, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 40);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Х";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButton.Location = new System.Drawing.Point(141, 293);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(236, 38);
            this.LogButton.TabIndex = 7;
            this.LogButton.Text = "Войти";
            this.LogButton.UseVisualStyleBackColor = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(141, 124);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginField.Size = new System.Drawing.Size(236, 33);
            this.LoginField.TabIndex = 2;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 427);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label ErrorMess;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button RegButton;
    }
}