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
    public partial class frmBorrowBooks : Form
    {
        public frmBorrowBooks()
        {
            InitializeComponent();
        }
        // To create placeholders
        private void tbReaderCode_Enter(object sender, EventArgs e)
        {
            if (tbReaderCode.Text == "Mã độc giả")
            {
                tbReaderCode.Text = "";
                tbReaderCode.ForeColor = Color.Black;
            }
        }
        private void tbReaderCode_Leave(object sender, EventArgs e)
        {
            if (tbReaderCode.Text == "")
            {
                tbReaderCode.Text = "Mã độc giả";
                tbReaderCode.ForeColor = Color.Gray;
            }
        }
        private void tbBookCode_Enter(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "Mã sách cần mượn")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "")
            {
                tbBookCode.Text = "Mã sách cần mượn";
                tbBookCode.ForeColor = Color.Gray;
            }
        }
        //end placeholders
    }
}
