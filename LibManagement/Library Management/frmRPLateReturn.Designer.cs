﻿namespace Library_Management
{
    partial class frmRPLateReturn
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lbYear = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.lbMonth = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Library_Management.DataSet1();
            this.DataTable1TableAdapter = new Library_Management.DataSet1TableAdapters.DataTable1TableAdapter();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnCreateReport);
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
            this.lbYear.Location = new System.Drawing.Point(282, 18);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(79, 36);
            this.lbYear.TabIndex = 30;
            this.lbYear.Text = "Năm";
            // 
            // dtpMonth
            // 
            this.dtpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonth.Location = new System.Drawing.Point(132, 64);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(125, 30);
            this.dtpMonth.TabIndex = 29;
            // 
            // dtpYear
            // 
            this.dtpYear.AllowDrop = true;
            this.dtpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Location = new System.Drawing.Point(285, 64);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(121, 30);
            this.dtpYear.TabIndex = 28;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(129, 18);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(105, 36);
            this.lbMonth.TabIndex = 25;
            this.lbMonth.Text = "Tháng";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Library_Management.Properties.Resources.administration;
            this.pictureBox4.Location = new System.Drawing.Point(9, 18);
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library_Management.ReportLateReturn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(882, 451);
            this.reportViewer1.TabIndex = 7;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.EnforceConstraints = false;
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReport.Location = new System.Drawing.Point(412, 63);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(165, 31);
            this.btnCreateReport.TabIndex = 31;
            this.btnCreateReport.Text = "Lập báo cáo";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // frmRPLateReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnFooter);
            this.Name = "frmRPLateReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sách trả muộn";
            this.Load += new System.EventHandler(this.frmRPLateReturn_Load);
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button btnCreateReport;
    }
}