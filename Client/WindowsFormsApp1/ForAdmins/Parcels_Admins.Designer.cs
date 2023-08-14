namespace WindowsFormsApp1
{
    partial class Parcels_Admins
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            this.WarehouseField = new System.Windows.Forms.ComboBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.ParcelNumField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorMess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.ErrorMes2 = new System.Windows.Forms.Label();
            this.DelNum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 168);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Дата прибытия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Номер склада";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Номер посылки";
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(93, 105);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(236, 20);
            this.DateField.TabIndex = 37;
            this.DateField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateField_KeyDown);
            // 
            // WarehouseField
            // 
            this.WarehouseField.FormattingEnabled = true;
            this.WarehouseField.Location = new System.Drawing.Point(93, 75);
            this.WarehouseField.Name = "WarehouseField";
            this.WarehouseField.Size = new System.Drawing.Size(236, 21);
            this.WarehouseField.TabIndex = 36;
            this.WarehouseField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WarehouseField_KeyDown);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(93, 45);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(236, 20);
            this.NameField.TabIndex = 35;
            this.NameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameField_KeyDown);
            // 
            // ParcelNumField
            // 
            this.ParcelNumField.Location = new System.Drawing.Point(93, 15);
            this.ParcelNumField.Name = "ParcelNumField";
            this.ParcelNumField.Size = new System.Drawing.Size(236, 20);
            this.ParcelNumField.TabIndex = 34;
            this.ParcelNumField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParcelNumField_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(298, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Посылки";
            // 
            // ErrorMess
            // 
            this.ErrorMess.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMess.Location = new System.Drawing.Point(89, 142);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(276, 23);
            this.ErrorMess.TabIndex = 43;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(348, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Номер посылки для удаления";
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(351, 42);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 46;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ErrorMes2
            // 
            this.ErrorMes2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMes2.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMes2.Location = new System.Drawing.Point(440, 42);
            this.ErrorMes2.Name = "ErrorMes2";
            this.ErrorMes2.Size = new System.Drawing.Size(189, 23);
            this.ErrorMes2.TabIndex = 48;
            this.ErrorMes2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DelNum
            // 
            this.DelNum.FormattingEnabled = true;
            this.DelNum.Location = new System.Drawing.Point(511, 15);
            this.DelNum.Name = "DelNum";
            this.DelNum.Size = new System.Drawing.Size(118, 21);
            this.DelNum.TabIndex = 64;
            this.DelNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DelNum_KeyDown);
            // 
            // Parcels_Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 371);
            this.Controls.Add(this.DelNum);
            this.Controls.Add(this.ErrorMes2);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ErrorMess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.WarehouseField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.ParcelNumField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Parcels_Admins";
            this.Text = "Parcels_Admins";
            this.Load += new System.EventHandler(this.Parcels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateField;
        private System.Windows.Forms.ComboBox WarehouseField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox ParcelNumField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrorMess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label ErrorMes2;
        private System.Windows.Forms.ComboBox DelNum;
    }
}