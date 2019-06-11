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
    public partial class frmBooksManage : Form
    {
        public frmBooksManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new book
            frmAddNewBooks frmAddNewBooks = new frmAddNewBooks();
            frmAddNewBooks.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // to create form to search books
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.ShowDialog();
        }

        //to create form to borrow books
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrowBooks frmBorrowBooks = new frmBorrowBooks();
            frmBorrowBooks.ShowDialog();
        }
        // to create a form to return books
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturnBooks frmReturnBooks = new frmReturnBooks();
            frmReturnBooks.ShowDialog();
        }
    }
}
