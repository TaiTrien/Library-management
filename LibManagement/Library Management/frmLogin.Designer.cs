namespace Library_Management
{
    partial class frmLogin
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.tbForgotPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbX = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.tbForgotPassword);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.pbX);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.tbPassword);
            this.pnLogin.Controls.Add(this.tbUserName);
            this.pnLogin.Controls.Add(this.pictureBox3);
            this.pnLogin.Controls.Add(this.pictureBox2);
            this.pnLogin.Controls.Add(this.pictureBox1);
            this.pnLogin.Location = new System.Drawing.Point(12, 12);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(311, 451);
            this.pnLogin.TabIndex = 0;
            // 
            // tbForgotPassword
            // 
            this.tbForgotPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbForgotPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForgotPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbForgotPassword.Location = new System.Drawing.Point(139, 326);
            this.tbForgotPassword.Multiline = true;
            this.tbForgotPassword.Name = "tbForgotPassword";
            this.tbForgotPassword.ReadOnly = true;
            this.tbForgotPassword.Size = new System.Drawing.Size(152, 22);
            this.tbForgotPassword.TabIndex = 16;
            this.tbForgotPassword.Text = "FORGOT PASSWORD?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(83, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 45);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbX
            // 
            this.pbX.Image = global::Library_Management.Properties.Resources.cancel2;
            this.pbX.Location = new System.Drawing.Point(263, 3);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(43, 50);
            this.pbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX.TabIndex = 14;
            this.pbX.TabStop = false;
            this.pbX.Click += new System.EventHandler(this.pbX_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(98, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 2);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(98, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 2);
            this.label1.TabIndex = 12;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbPassword.Location = new System.Drawing.Point(98, 275);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(144, 27);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.Text = "PASSWORD";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbUserName.Location = new System.Drawing.Point(98, 191);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(144, 27);
            this.tbUserName.TabIndex = 11;
            this.tbUserName.Text = "USER NAME";
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.key2;
            this.pictureBox3.Location = new System.Drawing.Point(17, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.user2;
            this.pictureBox2.Location = new System.Drawing.Point(17, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.login2;
            this.pictureBox1.Location = new System.Drawing.Point(83, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(343, 475);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbX;
    }
}

