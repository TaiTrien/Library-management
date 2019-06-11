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
    public partial class frmMenuReports : Form
    {
        public frmMenuReports()
        {
            InitializeComponent();
        }

        private void btnBorrowedBooks_Click(object sender, EventArgs e)
        {
            //To create form to report about borrowed books
            frmRPBorrowedBooks frmRPBorrowedBooks = new frmRPBorrowedBooks();
            frmRPBorrowedBooks.ShowDialog();
        }

        private void btnLateReturn_Click(object sender, EventArgs e)
        {
            //To create form to report about late return 
            frmLateReturn frmLateReturn = new frmLateReturn();
            frmLateReturn.ShowDialog();
        }
    }
}
