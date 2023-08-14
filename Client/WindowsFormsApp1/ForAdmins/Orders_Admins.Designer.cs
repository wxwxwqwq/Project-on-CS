namespace WindowsFormsApp1
{
    partial class Orders_Admins
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
            this.ErrorMess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientNum = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ParcelNum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DelNum = new System.Windows.Forms.ComboBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.ErrorMes2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorMess
            // 
            this.ErrorMess.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMess.Location = new System.Drawing.Point(96, 90);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(241, 23);
            this.ErrorMess.TabIndex = 60;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(301, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Заказы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Номер клиента";
            // 
            // ClientNum
            // 
            this.ClientNum.FormattingEnabled = true;
            this.ClientNum.Location = new System.Drawing.Point(101, 21);
            this.ClientNum.Name = "ClientNum";
            this.ClientNum.Size = new System.Drawing.Size(199, 21);
            this.ClientNum.TabIndex = 53;
            this.ClientNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientNum_KeyDown);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 207);
            this.dataGridView1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Номер посылки";
            // 
            // ParcelNum
            // 
            this.ParcelNum.FormattingEnabled = true;
            this.ParcelNum.Location = new System.Drawing.Point(101, 56);
            this.ParcelNum.Name = "ParcelNum";
            this.ParcelNum.Size = new System.Drawing.Size(199, 21);
            this.ParcelNum.TabIndex = 61;
            this.ParcelNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParcelNum_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(353, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Номер заказа для удаления";
            // 
            // DelNum
            // 
            this.DelNum.FormattingEnabled = true;
            this.DelNum.Location = new System.Drawing.Point(510, 21);
            this.DelNum.Name = "DelNum";
            this.DelNum.Size = new System.Drawing.Size(118, 21);
            this.DelNum.TabIndex = 63;
            this.DelNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DelNum_KeyDown);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(356, 56);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 65;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ErrorMes2
            // 
            this.ErrorMes2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMes2.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMes2.Location = new System.Drawing.Point(437, 56);
            this.ErrorMes2.Name = "ErrorMes2";
            this.ErrorMes2.Size = new System.Drawing.Size(189, 23);
            this.ErrorMes2.TabIndex = 66;
            this.ErrorMes2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Orders_Admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 371);
            this.Controls.Add(this.ErrorMes2);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParcelNum);
            this.Controls.Add(this.ErrorMess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Orders_Admins";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Admins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ErrorMess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClientNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ParcelNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DelNum;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label ErrorMes2;
    }
}