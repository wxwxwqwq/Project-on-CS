namespace WindowsFormsApp1
{
    partial class Warehouses_Admins
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.CapacityField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorMess = new System.Windows.Forms.Label();
            this.ErrorMes2 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DelNumField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 187);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddressField
            // 
            this.AddressField.Location = new System.Drawing.Point(97, 20);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(219, 20);
            this.AddressField.TabIndex = 2;
            this.AddressField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressField_KeyDown);
            // 
            // CapacityField
            // 
            this.CapacityField.Location = new System.Drawing.Point(97, 58);
            this.CapacityField.Name = "CapacityField";
            this.CapacityField.Size = new System.Drawing.Size(219, 20);
            this.CapacityField.TabIndex = 3;
            this.CapacityField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CapacityField_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вместимость \r\nсклада";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список складов";
            // 
            // ErrorMess
            // 
            this.ErrorMess.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMess.Location = new System.Drawing.Point(93, 110);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(276, 23);
            this.ErrorMess.TabIndex = 19;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorMes2
            // 
            this.ErrorMes2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMes2.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMes2.Location = new System.Drawing.Point(437, 58);
            this.ErrorMes2.Name = "ErrorMes2";
            this.ErrorMes2.Size = new System.Drawing.Size(195, 23);
            this.ErrorMes2.TabIndex = 52;
            this.ErrorMes2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(356, 58);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 51;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(353, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Номер склада для удаления";
            // 
            // DelNumField
            // 
            this.DelNumField.Location = new System.Drawing.Point(510, 20);
            this.DelNumField.Name = "DelNumField";
            this.DelNumField.Size = new System.Drawing.Size(116, 20);
            this.DelNumField.TabIndex = 49;
            this.DelNumField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DelNumField_KeyDown);
            // 
            // Warehouses_Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 371);
            this.Controls.Add(this.ErrorMes2);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DelNumField);
            this.Controls.Add(this.ErrorMess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CapacityField);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Warehouses_Admins";
            this.Text = "Warehouses_Admins";
            this.Load += new System.EventHandler(this.Warehouses_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Warehouses_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox CapacityField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorMess;
        private System.Windows.Forms.Label ErrorMes2;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DelNumField;
    }
}