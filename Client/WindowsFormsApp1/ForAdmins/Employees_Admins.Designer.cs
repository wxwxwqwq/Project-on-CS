namespace WindowsFormsApp1
{
    partial class Employees_Admins
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
            this.ErrorMes2 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.AdminPassField = new System.Windows.Forms.TextBox();
            this.EmpNumField = new System.Windows.Forms.TextBox();
            this.DelPassField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorMes2
            // 
            this.ErrorMes2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMes2.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMes2.Location = new System.Drawing.Point(436, 88);
            this.ErrorMes2.Name = "ErrorMes2";
            this.ErrorMes2.Size = new System.Drawing.Size(189, 23);
            this.ErrorMes2.TabIndex = 78;
            this.ErrorMes2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(355, 89);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 77;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(352, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Номер сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Пароль организации";
            // 
            // ErrorMess
            // 
            this.ErrorMess.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMess.Location = new System.Drawing.Point(93, 89);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(237, 23);
            this.ErrorMess.TabIndex = 72;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(107, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Список всех сотрудников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Номер пользователя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(362, 207);
            this.dataGridView1.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(130, 20);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(200, 20);
            this.LoginField.TabIndex = 79;
            // 
            // AdminPassField
            // 
            this.AdminPassField.Location = new System.Drawing.Point(130, 55);
            this.AdminPassField.Name = "AdminPassField";
            this.AdminPassField.Size = new System.Drawing.Size(200, 20);
            this.AdminPassField.TabIndex = 80;
            // 
            // EmpNumField
            // 
            this.EmpNumField.Location = new System.Drawing.Point(471, 20);
            this.EmpNumField.Name = "EmpNumField";
            this.EmpNumField.Size = new System.Drawing.Size(165, 20);
            this.EmpNumField.TabIndex = 81;
            // 
            // DelPassField
            // 
            this.DelPassField.Location = new System.Drawing.Point(471, 55);
            this.DelPassField.Name = "DelPassField";
            this.DelPassField.Size = new System.Drawing.Size(165, 20);
            this.DelPassField.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(352, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Пароль организации";
            // 
            // Employees_Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 371);
            this.Controls.Add(this.DelPassField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpNumField);
            this.Controls.Add(this.AdminPassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.ErrorMes2);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorMess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Employees_Admins";
            this.Text = "Employees_Admins";
            this.Load += new System.EventHandler(this.Employees_Admins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorMes2;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox AdminPassField;
        private System.Windows.Forms.TextBox EmpNumField;
        private System.Windows.Forms.TextBox DelPassField;
        private System.Windows.Forms.Label label4;
    }
}