namespace Library_Management
{
    partial class frmModTypes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTypeCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.diary;
            this.pictureBox1.Location = new System.Drawing.Point(84, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.coffee_cup;
            this.pictureBox2.Location = new System.Drawing.Point(84, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.Control;
            this.btnMod.BackgroundImage = global::Library_Management.Properties.Resources.maintenance;
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(534, 22);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(208, 188);
            this.btnMod.TabIndex = 36;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(175, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 2);
            this.label1.TabIndex = 35;
            // 
            // tbTypeName
            // 
            this.tbTypeName.BackColor = System.Drawing.SystemColors.Control;
            this.tbTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypeName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTypeName.Location = new System.Drawing.Point(179, 164);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(262, 20);
            this.tbTypeName.TabIndex = 34;
            this.tbTypeName.Text = "Tên thể loại";
            this.tbTypeName.Enter += new System.EventHandler(this.tbTypeName_Enter);
            this.tbTypeName.Leave += new System.EventHandler(this.tbTypeName_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(175, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 33;
            // 
            // tbTypeCode
            // 
            this.tbTypeCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypeCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTypeCode.Location = new System.Drawing.Point(179, 63);
            this.tbTypeCode.Name = "tbTypeCode";
            this.tbTypeCode.Size = new System.Drawing.Size(262, 20);
            this.tbTypeCode.TabIndex = 32;
            this.tbTypeCode.Text = "Mã thể loại";
            // 
            // frmModTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTypeCode);
            this.Name = "frmModTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thể loại";
            this.Load += new System.EventHandler(this.frmModTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbTypeCode;
    }
}