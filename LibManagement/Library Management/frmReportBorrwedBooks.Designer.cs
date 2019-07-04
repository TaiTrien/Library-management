namespace Library_Management
{
    partial class frmReportBorrwedBooks
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.THELOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBorrowedBook = new Library_Management.DataSetBorrowedBook();
            this.THELOAISACHTableAdapter = new Library_Management.DataSetBorrowedBookTableAdapters.THELOAISACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.THELOAISACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBorrowedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.THELOAISACHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library_Management.ReportBorrowedBooks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(882, 443);
            this.reportViewer1.TabIndex = 1;
            // 
            // THELOAISACHBindingSource
            // 
            this.THELOAISACHBindingSource.DataMember = "THELOAISACH";
            this.THELOAISACHBindingSource.DataSource = this.DataSetBorrowedBook;
            // 
            // DataSetBorrowedBook
            // 
            this.DataSetBorrowedBook.DataSetName = "DataSetBorrowedBook";
            this.DataSetBorrowedBook.EnforceConstraints = false;
            this.DataSetBorrowedBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THELOAISACHTableAdapter
            // 
            this.THELOAISACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportBorrwedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 443);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportBorrwedBooks";
            this.Text = "frmReportBorrwedBooks";
            this.Load += new System.EventHandler(this.frmReportBorrwedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.THELOAISACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBorrowedBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource THELOAISACHBindingSource;
        private DataSetBorrowedBook DataSetBorrowedBook;
        private DataSetBorrowedBookTableAdapters.THELOAISACHTableAdapter THELOAISACHTableAdapter;
    }
}