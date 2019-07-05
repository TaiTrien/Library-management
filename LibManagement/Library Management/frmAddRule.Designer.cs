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
            this.SuspendLayout();
            // 
            // btnMinAge
            // 
            this.btnMinAge.AutoSize = true;
            this.btnMinAge.Location = new System.Drawing.Point(73, 62);
            this.btnMinAge.Name = "btnMinAge";
            this.btnMinAge.Size = new System.Drawing.Size(100, 17);
            this.btnMinAge.TabIndex = 0;
            this.btnMinAge.Text = "Tuổi Tối Thiểu";
            // 
            // btnMaxAge
            // 
            this.btnMaxAge.AutoSize = true;
            this.btnMaxAge.Location = new System.Drawing.Point(457, 62);
            this.btnMaxAge.Name = "btnMaxAge";
            this.btnMaxAge.Size = new System.Drawing.Size(82, 17);
            this.btnMaxAge.TabIndex = 0;
            this.btnMaxAge.Text = "Tuổi Tối Đa";
            // 
            // btnTimexpReader
            // 
            this.btnTimexpReader.AutoSize = true;
            this.btnTimexpReader.Location = new System.Drawing.Point(73, 130);
            this.btnTimexpReader.Name = "btnTimexpReader";
            this.btnTimexpReader.Size = new System.Drawing.Size(115, 17);
            this.btnTimexpReader.TabIndex = 0;
            this.btnTimexpReader.Text = "Thời hạn của thẻ";
            // 
            // btnNumberTitles
            // 
            this.btnNumberTitles.AutoSize = true;
            this.btnNumberTitles.Location = new System.Drawing.Point(73, 203);
            this.btnNumberTitles.Name = "btnNumberTitles";
            this.btnNumberTitles.Size = new System.Drawing.Size(129, 17);
            this.btnNumberTitles.TabIndex = 0;
            this.btnNumberTitles.Text = "Số Lượng Thể Loại";
            this.btnNumberTitles.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnYearPublish
            // 
            this.btnYearPublish.AutoSize = true;
            this.btnYearPublish.Location = new System.Drawing.Point(73, 262);
            this.btnYearPublish.Name = "btnYearPublish";
            this.btnYearPublish.Size = new System.Drawing.Size(180, 17);
            this.btnYearPublish.TabIndex = 0;
            this.btnYearPublish.Text = "Khoảng cách năm xuất bản";
            this.btnYearPublish.Click += new System.EventHandler(this.btnYearPublish_Click);
            // 
            // btnMaxBookBorrow
            // 
            this.btnMaxBookBorrow.AutoSize = true;
            this.btnMaxBookBorrow.Location = new System.Drawing.Point(73, 321);
            this.btnMaxBookBorrow.Name = "btnMaxBookBorrow";
            this.btnMaxBookBorrow.Size = new System.Drawing.Size(146, 17);
            this.btnMaxBookBorrow.TabIndex = 0;
            this.btnMaxBookBorrow.Text = "Số Sách Mượn Tối Đa";
            // 
            // btnMaxDayBorrow
            // 
            this.btnMaxDayBorrow.AutoSize = true;
            this.btnMaxDayBorrow.Location = new System.Drawing.Point(457, 323);
            this.btnMaxDayBorrow.Name = "btnMaxDayBorrow";
            this.btnMaxDayBorrow.Size = new System.Drawing.Size(147, 17);
            this.btnMaxDayBorrow.TabIndex = 0;
            this.btnMaxDayBorrow.Text = "Số Ngày Mượn Tối Đa";
            // 
            // tbMinAgeReader
            // 
            this.tbMinAgeReader.Location = new System.Drawing.Point(323, 62);
            this.tbMinAgeReader.Name = "tbMinAgeReader";
            this.tbMinAgeReader.Size = new System.Drawing.Size(100, 22);
            this.tbMinAgeReader.TabIndex = 1;
            this.tbMinAgeReader.TextChanged += new System.EventHandler(this.tbMinAgeReader_TextChanged);
            this.tbMinAgeReader.Enter += new System.EventHandler(this.tbMinAgeReader_Enter);
            this.tbMinAgeReader.Leave += new System.EventHandler(this.tbMinAgeReader_Leave);
            // 
            // tbMaxAgeReader
            // 
            this.tbMaxAgeReader.Location = new System.Drawing.Point(629, 62);
            this.tbMaxAgeReader.Name = "tbMaxAgeReader";
            this.tbMaxAgeReader.Size = new System.Drawing.Size(100, 22);
            this.tbMaxAgeReader.TabIndex = 1;
            this.tbMaxAgeReader.Enter += new System.EventHandler(this.tbMaxAgeReader_Enter);
            this.tbMaxAgeReader.Leave += new System.EventHandler(this.tbMaxAgeReader_Leave);
            // 
            // txTimeExpReader
            // 
            this.txTimeExpReader.Location = new System.Drawing.Point(323, 127);
            this.txTimeExpReader.Name = "txTimeExpReader";
            this.txTimeExpReader.Size = new System.Drawing.Size(100, 22);
            this.txTimeExpReader.TabIndex = 1;
            this.txTimeExpReader.Enter += new System.EventHandler(this.txTimeExpReader_Enter);
            this.txTimeExpReader.Leave += new System.EventHandler(this.txTimeExpReader_Leave);
            // 
            // txNumberTitles
            // 
            this.txNumberTitles.Location = new System.Drawing.Point(323, 198);
            this.txNumberTitles.Name = "txNumberTitles";
            this.txNumberTitles.Size = new System.Drawing.Size(100, 22);
            this.txNumberTitles.TabIndex = 1;
            this.txNumberTitles.Enter += new System.EventHandler(this.txNumberTitles_Enter);
            this.txNumberTitles.Leave += new System.EventHandler(this.txNumberTitles_Leave);
            // 
            // tbYearPubish
            // 
            this.tbYearPubish.Location = new System.Drawing.Point(323, 262);
            this.tbYearPubish.Name = "tbYearPubish";
            this.tbYearPubish.Size = new System.Drawing.Size(100, 22);
            this.tbYearPubish.TabIndex = 1;
            this.tbYearPubish.Enter += new System.EventHandler(this.tbYearPubish_Enter);
            this.tbYearPubish.Leave += new System.EventHandler(this.tbYearPubish_Leave);
            // 
            // tbMaxBookBorrow
            // 
            this.tbMaxBookBorrow.Location = new System.Drawing.Point(323, 316);
            this.tbMaxBookBorrow.Name = "tbMaxBookBorrow";
            this.tbMaxBookBorrow.Size = new System.Drawing.Size(100, 22);
            this.tbMaxBookBorrow.TabIndex = 1;
            this.tbMaxBookBorrow.Enter += new System.EventHandler(this.tbMaxBookBorrow_Enter);
            this.tbMaxBookBorrow.Leave += new System.EventHandler(this.tbMaxBookBorrow_Leave);
            // 
            // tbMaxDayBorrow
            // 
            this.tbMaxDayBorrow.Location = new System.Drawing.Point(629, 318);
            this.tbMaxDayBorrow.Name = "tbMaxDayBorrow";
            this.tbMaxDayBorrow.Size = new System.Drawing.Size(100, 22);
            this.tbMaxDayBorrow.TabIndex = 1;
            this.tbMaxDayBorrow.Enter += new System.EventHandler(this.tbMinBookBorrow_Enter);
            this.tbMaxDayBorrow.Leave += new System.EventHandler(this.tbMaxDayBorrow_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(336, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 17);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbMaxAgeReader);
            this.Controls.Add(this.tbMaxDayBorrow);
            this.Controls.Add(this.tbMaxBookBorrow);
            this.Controls.Add(this.tbYearPubish);
            this.Controls.Add(this.txNumberTitles);
            this.Controls.Add(this.txTimeExpReader);
            this.Controls.Add(this.tbMinAgeReader);
            this.Controls.Add(this.btnMaxDayBorrow);
            this.Controls.Add(this.btnMaxBookBorrow);
            this.Controls.Add(this.btnYearPublish);
            this.Controls.Add(this.btnNumberTitles);
            this.Controls.Add(this.btnTimexpReader);
            this.Controls.Add(this.btnMaxAge);
            this.Controls.Add(this.btnMinAge);
            this.Name = "frmAddRule";
            this.Text = "frmAddRule";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}