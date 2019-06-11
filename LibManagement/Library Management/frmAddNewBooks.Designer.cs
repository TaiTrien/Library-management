namespace Library_Management
{
    partial class frmAddNewBooks
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
            this.lbDateIn = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpPublishYear = new System.Windows.Forms.DateTimePicker();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.cbTitleName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateIn
            // 
            this.lbDateIn.AutoSize = true;
            this.lbDateIn.Location = new System.Drawing.Point(97, 12);
            this.lbDateIn.Name = "lbDateIn";
            this.lbDateIn.Size = new System.Drawing.Size(77, 17);
            this.lbDateIn.TabIndex = 5;
            this.lbDateIn.Text = "Ngày nhập";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(536, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpDateIn.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpDateIn.Location = new System.Drawing.Point(207, 12);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(264, 22);
            this.dtpDateIn.TabIndex = 1;
            // 
            // tbBookCode
            // 
            this.tbBookCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbBookCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbBookCode.Location = new System.Drawing.Point(213, 69);
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(262, 20);
            this.tbBookCode.TabIndex = 3;
            this.tbBookCode.Text = "Mã sách";
            this.tbBookCode.Enter += new System.EventHandler(this.tbBookCode_Enter);
            this.tbBookCode.Leave += new System.EventHandler(this.tbBookCode_Leave);
            // 
            // tbPublisher
            // 
            this.tbPublisher.BackColor = System.Drawing.SystemColors.Control;
            this.tbPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublisher.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPublisher.Location = new System.Drawing.Point(213, 278);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(262, 20);
            this.tbPublisher.TabIndex = 7;
            this.tbPublisher.Text = "Nhà xuất bản";
            this.tbPublisher.Enter += new System.EventHandler(this.tbPublisher_Enter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(209, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(209, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 2);
            this.label5.TabIndex = 27;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Library_Management.Properties.Resources.money_bag;
            this.pictureBox6.Location = new System.Drawing.Point(99, 325);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Library_Management.Properties.Resources.pub;
            this.pictureBox5.Location = new System.Drawing.Point(99, 259);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Library_Management.Properties.Resources.calendar;
            this.pictureBox4.Location = new System.Drawing.Point(99, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.agenda;
            this.pictureBox2.Location = new System.Drawing.Point(99, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.notebook;
            this.pictureBox1.Location = new System.Drawing.Point(99, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::Library_Management.Properties.Resources.plus_128;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(579, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 188);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpPublishYear
            // 
            this.dtpPublishYear.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpPublishYear.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpPublishYear.Location = new System.Drawing.Point(207, 215);
            this.dtpPublishYear.Name = "dtpPublishYear";
            this.dtpPublishYear.Size = new System.Drawing.Size(264, 22);
            this.dtpPublishYear.TabIndex = 34;
            // 
            // nudValue
            // 
            this.nudValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nudValue.Location = new System.Drawing.Point(213, 345);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(257, 22);
            this.nudValue.TabIndex = 17;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbTitleName
            // 
            this.cbTitleName.FormattingEnabled = true;
            this.cbTitleName.Location = new System.Drawing.Point(207, 146);
            this.cbTitleName.Name = "cbTitleName";
            this.cbTitleName.Size = new System.Drawing.Size(268, 24);
            this.cbTitleName.TabIndex = 35;
            // 
            // frmAddNewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 413);
            this.Controls.Add(this.cbTitleName);
            this.Controls.Add(this.dtpPublishYear);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbBookCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.dtpDateIn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbDateIn);
            this.Name = "frmAddNewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận sách mới";
            this.Load += new System.EventHandler(this.frmAddNewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDateIn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpPublishYear;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.ComboBox cbTitleName;
    }
}