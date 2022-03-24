namespace SACtask2
{
    partial class Form1
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
            this.btn_cal = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.textbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaserprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(32, 29);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(203, 48);
            this.btn_cal.TabIndex = 0;
            this.btn_cal.Text = "Chose file and Calculate Profit";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textbook,
            this.subject,
            this.seller,
            this.purchaser,
            this.purchaserprice,
            this.saleprice,
            this.profit});
            this.table.Location = new System.Drawing.Point(32, 104);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 62;
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(1132, 334);
            this.table.TabIndex = 1;
            // 
            // textbook
            // 
            this.textbook.HeaderText = "Textbook";
            this.textbook.MinimumWidth = 8;
            this.textbook.Name = "textbook";
            this.textbook.Width = 150;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 8;
            this.subject.Name = "subject";
            this.subject.Width = 150;
            // 
            // seller
            // 
            this.seller.HeaderText = "Seller";
            this.seller.MinimumWidth = 8;
            this.seller.Name = "seller";
            this.seller.Width = 150;
            // 
            // purchaser
            // 
            this.purchaser.HeaderText = "Purchaser";
            this.purchaser.MinimumWidth = 8;
            this.purchaser.Name = "purchaser";
            this.purchaser.Width = 150;
            // 
            // purchaserprice
            // 
            this.purchaserprice.HeaderText = "Purchaser Price";
            this.purchaserprice.MinimumWidth = 8;
            this.purchaserprice.Name = "purchaserprice";
            this.purchaserprice.Width = 150;
            // 
            // saleprice
            // 
            this.saleprice.HeaderText = "Sale Price";
            this.saleprice.MinimumWidth = 8;
            this.saleprice.Name = "saleprice";
            this.saleprice.Width = 150;
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.MinimumWidth = 8;
            this.profit.Name = "profit";
            this.profit.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 450);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_cal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaserprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
    }
}

