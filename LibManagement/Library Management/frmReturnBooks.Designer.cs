namespace Library_Management
{
    partial class frmReturnBooks
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReaderCode = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbBookCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbReaderCode);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Location = new System.Drawing.Point(370, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 331);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(65, 150);
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
            this.tbBookCode.Location = new System.Drawing.Point(68, 114);
            this.tbBookCode.Multiline = true;
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(310, 51);
            this.tbBookCode.TabIndex = 45;
            this.tbBookCode.Text = "Mã sách cần trả";
            this.tbBookCode.Enter += new System.EventHandler(this.tbBookCode_Enter);
            this.tbBookCode.Leave += new System.EventHandler(this.tbBookCode_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(65, 81);
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
            this.tbReaderCode.Location = new System.Drawing.Point(68, 41);
            this.tbReaderCode.Multiline = true;
            this.tbReaderCode.Name = "tbReaderCode";
            this.tbReaderCode.Size = new System.Drawing.Size(295, 46);
            this.tbReaderCode.TabIndex = 43;
            this.tbReaderCode.Text = "Mã độc giả";
            this.tbReaderCode.Enter += new System.EventHandler(this.tbReaderCode_Enter);
            this.tbReaderCode.Leave += new System.EventHandler(this.tbReaderCode_Leave);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(93, 234);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(270, 75);
            this.btnBorrow.TabIndex = 42;
            this.btnBorrow.Text = "Trả";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.UIT;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận trả sách";
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
    }
}