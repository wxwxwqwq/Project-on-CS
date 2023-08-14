namespace WindowsFormsApp1
{
    partial class Admins_Users
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminPassField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Контактные данные администраторов\r\n";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(362, 310);
            this.dataGridView1.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 24);
            this.button1.TabIndex = 74;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPassField
            // 
            this.AdminPassField.Location = new System.Drawing.Point(534, 36);
            this.AdminPassField.Name = "AdminPassField";
            this.AdminPassField.Size = new System.Drawing.Size(98, 20);
            this.AdminPassField.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Пароль организации";
            // 
            // ErrorMess
            // 
            this.ErrorMess.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMess.Location = new System.Drawing.Point(418, 114);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(214, 23);
            this.ErrorMess.TabIndex = 77;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Admins_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 371);
            this.Controls.Add(this.ErrorMess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminPassField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admins_Users";
            this.Text = "Admins";
            this.Load += new System.EventHandler(this.Admins_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AdminPassField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMess;
    }
}