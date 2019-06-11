namespace Library_Management
{
    partial class frmAddNewReaders
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
            this.dtpDateCreateCard = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbDateCreateCard = new System.Windows.Forms.Label();
            this.cbTypeofReaders = new System.Windows.Forms.ComboBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateCreateCard
            // 
            this.dtpDateCreateCard.Location = new System.Drawing.Point(183, 12);
            this.dtpDateCreateCard.Name = "dtpDateCreateCard";
            this.dtpDateCreateCard.Size = new System.Drawing.Size(244, 22);
            this.dtpDateCreateCard.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(538, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbEmail.Location = new System.Drawing.Point(183, 370);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 22);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Text = "example@gmail.com";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbAddress.Location = new System.Drawing.Point(183, 304);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(244, 15);
            this.tbAddress.TabIndex = 5;
            this.tbAddress.Text = "Địa chỉ";
            this.tbAddress.Enter += new System.EventHandler(this.tbAddress_Enter);
            this.tbAddress.Leave += new System.EventHandler(this.tbAddress_Leave);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Control;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbName.Location = new System.Drawing.Point(183, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 15);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "Họ tên";
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // lbDateCreateCard
            // 
            this.lbDateCreateCard.AutoSize = true;
            this.lbDateCreateCard.Location = new System.Drawing.Point(51, 12);
            this.lbDateCreateCard.Name = "lbDateCreateCard";
            this.lbDateCreateCard.Size = new System.Drawing.Size(88, 17);
            this.lbDateCreateCard.TabIndex = 24;
            this.lbDateCreateCard.Text = "Ngày lập thẻ";
            // 
            // cbTypeofReaders
            // 
            this.cbTypeofReaders.BackColor = System.Drawing.SystemColors.Control;
            this.cbTypeofReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeofReaders.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbTypeofReaders.FormattingEnabled = true;
            this.cbTypeofReaders.Location = new System.Drawing.Point(183, 144);
            this.cbTypeofReaders.Name = "cbTypeofReaders";
            this.cbTypeofReaders.Size = new System.Drawing.Size(244, 24);
            this.cbTypeofReaders.TabIndex = 3;
            this.cbTypeofReaders.Text = "Loại độc giả";
            this.cbTypeofReaders.Enter += new System.EventHandler(this.cbTypeofReaders_Enter);
            this.cbTypeofReaders.Leave += new System.EventHandler(this.cbTypeofReaders_Leave);
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.dtpDob.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.dtpDob.Location = new System.Drawing.Point(183, 227);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(263, 22);
            this.dtpDob.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(184, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 2);
            this.label1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(184, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(184, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 2);
            this.label3.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(184, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 2);
            this.label4.TabIndex = 40;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Library_Management.Properties.Resources.envelope;
            this.pictureBox6.Location = new System.Drawing.Point(80, 351);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 46;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Library_Management.Properties.Resources.map;
            this.pictureBox5.Location = new System.Drawing.Point(80, 275);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Library_Management.Properties.Resources.bald_man_with_glasses;
            this.pictureBox4.Location = new System.Drawing.Point(80, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.cake;
            this.pictureBox3.Location = new System.Drawing.Point(80, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.name;
            this.pictureBox1.Location = new System.Drawing.Point(80, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::Library_Management.Properties.Resources.plus_128;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(528, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 188);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmAddNewReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.cbTypeofReaders);
            this.Controls.Add(this.dtpDateCreateCard);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbDateCreateCard);
            this.Name = "frmAddNewReaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập thẻ độc giả";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDateCreateCard;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbDateCreateCard;
        private System.Windows.Forms.ComboBox cbTypeofReaders;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAdd;
    }
}