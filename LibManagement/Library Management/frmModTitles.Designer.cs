﻿namespace Library_Management
{
    partial class frmModTitles
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
            this.lbAuth = new System.Windows.Forms.Label();
            this.lsbAuth = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbType = new System.Windows.Forms.ListBox();
            this.tbTitlesName = new System.Windows.Forms.TextBox();
            this.tbTitlesCode = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbAuth);
            this.panel1.Controls.Add(this.lsbAuth);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lsbType);
            this.panel1.Controls.Add(this.tbTitlesName);
            this.panel1.Controls.Add(this.tbTitlesCode);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 235);
            this.panel1.TabIndex = 47;
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Location = new System.Drawing.Point(530, 7);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(55, 17);
            this.lbAuth.TabIndex = 56;
            this.lbAuth.Text = "Tác giả";
            // 
            // lsbAuth
            // 
            this.lsbAuth.BackColor = System.Drawing.SystemColors.Control;
            this.lsbAuth.FormattingEnabled = true;
            this.lsbAuth.ItemHeight = 16;
            this.lsbAuth.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.lsbAuth.Location = new System.Drawing.Point(533, 30);
            this.lsbAuth.Name = "lsbAuth";
            this.lsbAuth.Size = new System.Drawing.Size(200, 52);
            this.lsbAuth.TabIndex = 55;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.agenda;
            this.pictureBox2.Location = new System.Drawing.Point(34, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.notebook;
            this.pictureBox1.Location = new System.Drawing.Point(35, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(121, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(121, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 2);
            this.label1.TabIndex = 51;
            // 
            // lsbType
            // 
            this.lsbType.BackColor = System.Drawing.SystemColors.Control;
            this.lsbType.FormattingEnabled = true;
            this.lsbType.ItemHeight = 16;
            this.lsbType.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.lsbType.Location = new System.Drawing.Point(533, 150);
            this.lsbType.Name = "lsbType";
            this.lsbType.Size = new System.Drawing.Size(200, 52);
            this.lsbType.TabIndex = 50;
            // 
            // tbTitlesName
            // 
            this.tbTitlesName.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitlesName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitlesName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTitlesName.Location = new System.Drawing.Point(124, 170);
            this.tbTitlesName.Name = "tbTitlesName";
            this.tbTitlesName.Size = new System.Drawing.Size(200, 15);
            this.tbTitlesName.TabIndex = 49;
            this.tbTitlesName.Text = "Tên đầu sách";
            // 
            // tbTitlesCode
            // 
            this.tbTitlesCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitlesCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitlesCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTitlesCode.Location = new System.Drawing.Point(124, 51);
            this.tbTitlesCode.Name = "tbTitlesCode";
            this.tbTitlesCode.Size = new System.Drawing.Size(200, 15);
            this.tbTitlesCode.TabIndex = 48;
            this.tbTitlesCode.Text = "Mã đầu sách";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(530, 126);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(59, 17);
            this.lbType.TabIndex = 47;
            this.lbType.Text = "Thể loại";
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.Control;
            this.btnMod.BackgroundImage = global::Library_Management.Properties.Resources.maintenance;
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(12, 269);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(776, 58);
            this.btnMod.TabIndex = 46;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // frmModTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMod);
            this.Name = "frmModTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa đầu sách";
            this.Load += new System.EventHandler(this.frmModTitles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAuth;
        public System.Windows.Forms.ListBox lsbAuth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lsbType;
        public System.Windows.Forms.TextBox tbTitlesName;
        public System.Windows.Forms.TextBox tbTitlesCode;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnMod;
    }
}