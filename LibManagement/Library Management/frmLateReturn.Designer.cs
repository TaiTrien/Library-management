namespace Library_Management
{
    partial class frmLateReturn
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
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lbYear = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.lbYear);
            this.pnFooter.Controls.Add(this.dtpMonth);
            this.pnFooter.Controls.Add(this.dtpYear);
            this.pnFooter.Controls.Add(this.lbMonth);
            this.pnFooter.Controls.Add(this.pictureBox4);
            this.pnFooter.Controls.Add(this.pictureBox3);
            this.pnFooter.Controls.Add(this.pictureBox2);
            this.pnFooter.Controls.Add(this.pictureBox1);
            this.pnFooter.Controls.Add(this.lbContact);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 451);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(882, 108);
            this.pnFooter.TabIndex = 5;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(316, 18);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(79, 36);
            this.lbYear.TabIndex = 30;
            this.lbYear.Text = "Năm";
            // 
            // dtpMonth
            // 
            this.dtpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonth.Location = new System.Drawing.Point(166, 64);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(125, 30);
            this.dtpMonth.TabIndex = 29;
            // 
            // dtpYear
            // 
            this.dtpYear.AllowDrop = true;
            this.dtpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Location = new System.Drawing.Point(319, 64);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(121, 30);
            this.dtpYear.TabIndex = 28;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(163, 18);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(105, 36);
            this.lbMonth.TabIndex = 25;
            this.lbMonth.Text = "Tháng";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(594, 62);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(90, 25);
            this.lbContact.TabIndex = 17;
            this.lbContact.Text = "Liên hệ:";
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowTemplate.Height = 24;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(882, 430);
            this.dgvBorrowedBooks.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Library_Management.Properties.Resources.administration;
            this.pictureBox4.Location = new System.Drawing.Point(43, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.facebook;
            this.pictureBox3.Location = new System.Drawing.Point(820, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.linkedin;
            this.pictureBox2.Location = new System.Drawing.Point(762, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.github;
            this.pictureBox1.Location = new System.Drawing.Point(702, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmLateReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Name = "frmLateReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sách trả muộn";
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
    }
}