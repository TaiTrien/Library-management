namespace Library_Management
{
    partial class frmAddRule
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
            this.btnMinAge = new System.Windows.Forms.Label();
            this.btnMaxAge = new System.Windows.Forms.Label();
            this.btnTimexpReader = new System.Windows.Forms.Label();
            this.btnNumberTitles = new System.Windows.Forms.Label();
            this.btnYearPublish = new System.Windows.Forms.Label();
            this.btnMaxBookBorrow = new System.Windows.Forms.Label();
            this.btnMaxDayBorrow = new System.Windows.Forms.Label();
            this.tbMinAgeReader = new System.Windows.Forms.TextBox();
            this.tbMaxAgeReader = new System.Windows.Forms.TextBox();
            this.txTimeExpReader = new System.Windows.Forms.TextBox();
            this.txNumberTitles = new System.Windows.Forms.TextBox();
            this.tbYearPubish = new System.Windows.Forms.TextBox();
            this.tbMaxBookBorrow = new System.Windows.Forms.TextBox();
            this.tbMaxDayBorrow = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinAge
            // 
            this.btnMinAge.AutoSize = true;
            this.btnMinAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinAge.Location = new System.Drawing.Point(6, 52);
            this.btnMinAge.Name = "btnMinAge";
            this.btnMinAge.Size = new System.Drawing.Size(153, 25);
            this.btnMinAge.TabIndex = 0;
            this.btnMinAge.Text = "Tuổi Tối Thiểu";
            // 
            // btnMaxAge
            // 
            this.btnMaxAge.AutoSize = true;
            this.btnMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxAge.Location = new System.Drawing.Point(6, 101);
            this.btnMaxAge.Name = "btnMaxAge";
            this.btnMaxAge.Size = new System.Drawing.Size(125, 25);
            this.btnMaxAge.TabIndex = 0;
            this.btnMaxAge.Text = "Tuổi Tối Đa";
            // 
            // btnTimexpReader
            // 
            this.btnTimexpReader.AutoSize = true;
            this.btnTimexpReader.Location = new System.Drawing.Point(6, 150);
            this.btnTimexpReader.Name = "btnTimexpReader";
            this.btnTimexpReader.Size = new System.Drawing.Size(206, 29);
            this.btnTimexpReader.TabIndex = 0;
            this.btnTimexpReader.Text = "Thời hạn của thẻ";
            // 
            // btnNumberTitles
            // 
            this.btnNumberTitles.AutoSize = true;
            this.btnNumberTitles.Location = new System.Drawing.Point(8, 57);
            this.btnNumberTitles.Name = "btnNumberTitles";
            this.btnNumberTitles.Size = new System.Drawing.Size(234, 29);
            this.btnNumberTitles.TabIndex = 0;
            this.btnNumberTitles.Text = "Số Lượng Thể Loại";
            this.btnNumberTitles.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnYearPublish
            // 
            this.btnYearPublish.AutoSize = true;
            this.btnYearPublish.Location = new System.Drawing.Point(6, 106);
            this.btnYearPublish.Name = "btnYearPublish";
            this.btnYearPublish.Size = new System.Drawing.Size(323, 29);
            this.btnYearPublish.TabIndex = 0;
            this.btnYearPublish.Text = "Khoảng cách năm xuất bản";
            this.btnYearPublish.Click += new System.EventHandler(this.btnYearPublish_Click);
            // 
            // btnMaxBookBorrow
            // 
            this.btnMaxBookBorrow.AutoSize = true;
            this.btnMaxBookBorrow.Location = new System.Drawing.Point(6, 204);
            this.btnMaxBookBorrow.Name = "btnMaxBookBorrow";
            this.btnMaxBookBorrow.Size = new System.Drawing.Size(266, 29);
            this.btnMaxBookBorrow.TabIndex = 0;
            this.btnMaxBookBorrow.Text = "Số Sách Mượn Tối Đa";
            // 
            // btnMaxDayBorrow
            // 
            this.btnMaxDayBorrow.AutoSize = true;
            this.btnMaxDayBorrow.Location = new System.Drawing.Point(6, 262);
            this.btnMaxDayBorrow.Name = "btnMaxDayBorrow";
            this.btnMaxDayBorrow.Size = new System.Drawing.Size(268, 29);
            this.btnMaxDayBorrow.TabIndex = 0;
            this.btnMaxDayBorrow.Text = "Số Ngày Mượn Tối Đa";
            // 
            // tbMinAgeReader
            // 
            this.tbMinAgeReader.Location = new System.Drawing.Point(301, 52);
            this.tbMinAgeReader.Name = "tbMinAgeReader";
            this.tbMinAgeReader.Size = new System.Drawing.Size(145, 34);
            this.tbMinAgeReader.TabIndex = 1;
            this.tbMinAgeReader.TextChanged += new System.EventHandler(this.tbMinAgeReader_TextChanged);
            this.tbMinAgeReader.Enter += new System.EventHandler(this.tbMinAgeReader_Enter);
            this.tbMinAgeReader.Leave += new System.EventHandler(this.tbMinAgeReader_Leave);
            // 
            // tbMaxAgeReader
            // 
            this.tbMaxAgeReader.Location = new System.Drawing.Point(301, 101);
            this.tbMaxAgeReader.Name = "tbMaxAgeReader";
            this.tbMaxAgeReader.Size = new System.Drawing.Size(145, 34);
            this.tbMaxAgeReader.TabIndex = 1;
            this.tbMaxAgeReader.Enter += new System.EventHandler(this.tbMaxAgeReader_Enter);
            this.tbMaxAgeReader.Leave += new System.EventHandler(this.tbMaxAgeReader_Leave);
            // 
            // txTimeExpReader
            // 
            this.txTimeExpReader.Location = new System.Drawing.Point(301, 150);
            this.txTimeExpReader.Name = "txTimeExpReader";
            this.txTimeExpReader.Size = new System.Drawing.Size(145, 34);
            this.txTimeExpReader.TabIndex = 1;
            this.txTimeExpReader.Enter += new System.EventHandler(this.txTimeExpReader_Enter);
            this.txTimeExpReader.Leave += new System.EventHandler(this.txTimeExpReader_Leave);
            // 
            // txNumberTitles
            // 
            this.txNumberTitles.Location = new System.Drawing.Point(388, 54);
            this.txNumberTitles.Name = "txNumberTitles";
            this.txNumberTitles.Size = new System.Drawing.Size(128, 34);
            this.txNumberTitles.TabIndex = 1;
            this.txNumberTitles.Enter += new System.EventHandler(this.txNumberTitles_Enter);
            this.txNumberTitles.Leave += new System.EventHandler(this.txNumberTitles_Leave);
            // 
            // tbYearPubish
            // 
            this.tbYearPubish.Location = new System.Drawing.Point(388, 106);
            this.tbYearPubish.Name = "tbYearPubish";
            this.tbYearPubish.Size = new System.Drawing.Size(128, 34);
            this.tbYearPubish.TabIndex = 1;
            this.tbYearPubish.Enter += new System.EventHandler(this.tbYearPubish_Enter);
            this.tbYearPubish.Leave += new System.EventHandler(this.tbYearPubish_Leave);
            // 
            // tbMaxBookBorrow
            // 
            this.tbMaxBookBorrow.Location = new System.Drawing.Point(301, 206);
            this.tbMaxBookBorrow.Name = "tbMaxBookBorrow";
            this.tbMaxBookBorrow.Size = new System.Drawing.Size(145, 34);
            this.tbMaxBookBorrow.TabIndex = 1;
            this.tbMaxBookBorrow.Enter += new System.EventHandler(this.tbMaxBookBorrow_Enter);
            this.tbMaxBookBorrow.Leave += new System.EventHandler(this.tbMaxBookBorrow_Leave);
            // 
            // tbMaxDayBorrow
            // 
            this.tbMaxDayBorrow.Location = new System.Drawing.Point(301, 265);
            this.tbMaxDayBorrow.Name = "tbMaxDayBorrow";
            this.tbMaxDayBorrow.Size = new System.Drawing.Size(145, 34);
            this.tbMaxDayBorrow.TabIndex = 1;
            this.tbMaxDayBorrow.Enter += new System.EventHandler(this.tbMinBookBorrow_Enter);
            this.tbMaxDayBorrow.Leave += new System.EventHandler(this.tbMaxDayBorrow_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Image = global::Library_Management.Properties.Resources.maintenance;
            this.btnUpdate.Location = new System.Drawing.Point(552, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(516, 165);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnMinAge);
            this.groupBox1.Controls.Add(this.btnMaxAge);
            this.groupBox1.Controls.Add(this.tbMinAgeReader);
            this.groupBox1.Controls.Add(this.tbMaxDayBorrow);
            this.groupBox1.Controls.Add(this.tbMaxAgeReader);
            this.groupBox1.Controls.Add(this.btnMaxDayBorrow);
            this.groupBox1.Controls.Add(this.tbMaxBookBorrow);
            this.groupBox1.Controls.Add(this.btnTimexpReader);
            this.groupBox1.Controls.Add(this.txTimeExpReader);
            this.groupBox1.Controls.Add(this.btnMaxBookBorrow);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 333);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THẺ ĐỘC GIẢ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnYearPublish);
            this.groupBox2.Controls.Add(this.tbYearPubish);
            this.groupBox2.Controls.Add(this.btnNumberTitles);
            this.groupBox2.Controls.Add(this.txNumberTitles);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(552, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 220);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SÁCH";
            // 
            // frmAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1158, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmAddRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa các qui định";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnMinAge;
        private System.Windows.Forms.Label btnMaxAge;
        private System.Windows.Forms.Label btnTimexpReader;
        private System.Windows.Forms.Label btnNumberTitles;
        private System.Windows.Forms.Label btnYearPublish;
        private System.Windows.Forms.Label btnMaxBookBorrow;
        private System.Windows.Forms.Label btnMaxDayBorrow;
        private System.Windows.Forms.TextBox tbMinAgeReader;
        private System.Windows.Forms.TextBox tbMaxAgeReader;
        private System.Windows.Forms.TextBox txTimeExpReader;
        private System.Windows.Forms.TextBox txNumberTitles;
        private System.Windows.Forms.TextBox tbYearPubish;
        private System.Windows.Forms.TextBox tbMaxBookBorrow;
        private System.Windows.Forms.TextBox tbMaxDayBorrow;
        private System.Windows.Forms.Label btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}