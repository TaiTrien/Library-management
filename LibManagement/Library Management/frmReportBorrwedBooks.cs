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
    public partial class frmReportBorrwedBooks : Form
    {
        public frmReportBorrwedBooks()
        {
            InitializeComponent();
        }

        private void frmReportBorrwedBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBorrowedBook.THELOAISACH' table. You can move, or remove it, as needed.
            this.THELOAISACHTableAdapter.Fill(this.DataSetBorrowedBook.THELOAISACH);

            this.reportViewer1.RefreshReport();
        }
    }
}
