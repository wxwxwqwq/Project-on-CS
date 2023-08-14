namespace WindowsFormsApp1
{
    partial class ParcelsAdd
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ParcelNumField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.WarehouseField = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.MinimizeButton.Location = new System.Drawing.Point(276, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 40);
            this.MinimizeButton.TabIndex = 23;
            this.MinimizeButton.Text = "__";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
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
            this.CloseButton.Location = new System.Drawing.Point(315, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 40);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "Х";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ParcelNumField
            // 
            this.ParcelNumField.Location = new System.Drawing.Point(42, 100);
            this.ParcelNumField.Name = "ParcelNumField";
            this.ParcelNumField.Size = new System.Drawing.Size(272, 20);
            this.ParcelNumField.TabIndex = 24;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(42, 280);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(272, 20);
            this.NameField.TabIndex = 26;
            // 
            // WarehouseField
            // 
            this.WarehouseField.FormattingEnabled = true;
            this.WarehouseField.Location = new System.Drawing.Point(42, 160);
            this.WarehouseField.Name = "WarehouseField";
            this.WarehouseField.Size = new System.Drawing.Size(272, 21);
            this.WarehouseField.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(42, 220);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(272, 20);
            this.DateField.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Номер склада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Дата прибытия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Описание";
            // 
            // ParcelsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WarehouseField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.ParcelNumField);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParcelsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ParcelsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox ParcelNumField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.ComboBox WarehouseField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}