namespace Library_Management
{
    partial class frmBorrowBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdBorrowBook = new System.Windows.Forms.TextBox();
            this.DateBorrowdtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReaderCode = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbIdBorrowBook);
            this.panel1.Controls.Add(this.DateBorrowdtp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbBookCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbReaderCode);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Location = new System.Drawing.Point(370, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 403);
            this.panel1.TabIndex = 0;
            // 
            // tbIdBorrowBook
            // 
            this.tbIdBorrowBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdBorrowBook.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbIdBorrowBook.Location = new System.Drawing.Point(68, 15);
            this.tbIdBorrowBook.Multiline = true;
            this.tbIdBorrowBook.Name = "tbIdBorrowBook";
            this.tbIdBorrowBook.Size = new System.Drawing.Size(270, 55);
            this.tbIdBorrowBook.TabIndex = 2;
            this.tbIdBorrowBook.Text = "Mã phiếu mượn";
            this.tbIdBorrowBook.Enter += new System.EventHandler(this.tbIdBorrowBook_Enter);
            this.tbIdBorrowBook.Leave += new System.EventHandler(this.tbIdBorrowBook_Leave);
            // 
            // DateBorrowdtp
            // 
            this.DateBorrowdtp.Location = new System.Drawing.Point(68, 272);
            this.DateBorrowdtp.Name = "DateBorrowdtp";
            this.DateBorrowdtp.Size = new System.Drawing.Size(310, 22);
            this.DateBorrowdtp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(65, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 2);
            this.label2.TabIndex = 46;
            // 
            // tbBookCode
            // 
            this.tbBookCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbBookCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbBookCode.Location = new System.Drawing.Point(68, 156);
            this.tbBookCode.Multiline = true;
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(310, 51);
            this.tbBookCode.TabIndex = 4;
            this.tbBookCode.Text = "Mã sách cần mượn";
            this.tbBookCode.Enter += new System.EventHandler(this.tbBookCode_Enter);
            this.tbBookCode.Leave += new System.EventHandler(this.tbBookCode_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(65, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 2);
            this.label1.TabIndex = 44;
            // 
            // tbReaderCode
            // 
            this.tbReaderCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbReaderCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReaderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReaderCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbReaderCode.Location = new System.Drawing.Point(68, 83);
            this.tbReaderCode.Multiline = true;
            this.tbReaderCode.Name = "tbReaderCode";
            this.tbReaderCode.Size = new System.Drawing.Size(295, 46);
            this.tbReaderCode.TabIndex = 3;
            this.tbReaderCode.Text = "Mã độc giả";
            this.tbReaderCode.TextChanged += new System.EventHandler(this.tbReaderCode_TextChanged);
            this.tbReaderCode.Enter += new System.EventHandler(this.tbReaderCode_Enter);
            this.tbReaderCode.Leave += new System.EventHandler(this.tbReaderCode_Leave);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(68, 312);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(310, 75);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Mượn";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.UIT;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ngày mượn";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(65, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 2);
            this.label3.TabIndex = 51;
            // 
            // frmBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBorrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReaderCode;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DateBorrowdtp;
        private System.Windows.Forms.TextBox tbIdBorrowBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}