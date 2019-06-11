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
    public partial class frmReturnBooks : Form
    {
        public frmReturnBooks()
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
            if (tbBookCode.Text == "Mã sách cần trả")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbReaderCode.Text == "")
            {
                tbReaderCode.Text = "Mã sách cần trả";
                tbReaderCode.ForeColor = Color.Gray;
            }
        }
        //end placeholders
    }
}
