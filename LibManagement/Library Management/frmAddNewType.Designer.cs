namespace Library_Management
{
    partial class frmAddNewType
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbTypeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(162, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 26;
            // 
            // tbTypeCode
            // 
            this.tbTypeCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypeCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTypeCode.Location = new System.Drawing.Point(166, 66);
            this.tbTypeCode.Name = "tbTypeCode";
            this.tbTypeCode.Size = new System.Drawing.Size(262, 20);
            this.tbTypeCode.TabIndex = 25;
            this.tbTypeCode.Text = "Mã thể loại";
            this.tbTypeCode.Enter += new System.EventHandler(this.tbTypeCode_Enter);
            this.tbTypeCode.Leave += new System.EventHandler(this.tbTypeCode_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(162, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 2);
            this.label1.TabIndex = 28;
            // 
            // tbTypeName
            // 
            this.tbTypeName.BackColor = System.Drawing.SystemColors.Control;
            this.tbTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypeName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTypeName.Location = new System.Drawing.Point(166, 167);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(262, 20);
            this.tbTypeName.TabIndex = 27;
            this.tbTypeName.Text = "Tên thể loại";
            this.tbTypeName.Enter += new System.EventHandler(this.tbTypeName_Enter);
            this.tbTypeName.Leave += new System.EventHandler(this.tbTypeName_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.diary;
            this.pictureBox1.Location = new System.Drawing.Point(71, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.coffee_cup;
            this.pictureBox2.Location = new System.Drawing.Point(71, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::Library_Management.Properties.Resources.plus_128;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(546, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 188);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddNewType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTypeCode);
            this.Name = "frmAddNewType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thể loại mới";
            this.Load += new System.EventHandler(this.frmAddNewType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTypeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}