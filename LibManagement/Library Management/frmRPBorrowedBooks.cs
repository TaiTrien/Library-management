using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmRPBorrowedBooks : Form
    {
        public frmRPBorrowedBooks()
        {
            InitializeComponent();
            //Custom date time pick to display only month
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MM";
            dtpMonth.ShowUpDown = true;
           
            //Custom date time pick to display only year
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
        }

        private void frmRPBorrowedBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBorrowedBook.THELOAISACH' table. You can move, or remove it, as needed.
            this.THELOAISACHTableAdapter.Fill(this.DataSetBorrowedBook.THELOAISACH, Decimal.Parse(dtpMonth.Text), Decimal.Parse(dtpYear.Text));

            this.reportViewer1.RefreshReport();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            this.THELOAISACHTableAdapter.Fill(this.DataSetBorrowedBook.THELOAISACH, Decimal.Parse(dtpMonth.Text), Decimal.Parse(dtpYear.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
