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
    public partial class frmAddNewReaders : Form
    {
        public frmAddNewReaders()
        {
            InitializeComponent();
        }
        // To set placeholders for textboxs
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Họ tên")
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }
        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Họ tên";
                tbName.ForeColor = Color.Gray;
            }
        }
        private void cbTypeofReaders_Enter(object sender, EventArgs e)
        {
            if (cbTypeofReaders.Text == "Loại độc giả")
            {
                cbTypeofReaders.Text = "";
                cbTypeofReaders.ForeColor = Color.Black;
            }
        }
        private void cbTypeofReaders_Leave(object sender, EventArgs e)
        {
            if (cbTypeofReaders.Text == "")
            {
                cbTypeofReaders.Text = "Loại độc giả";
                cbTypeofReaders.ForeColor = Color.Gray;
            }
        }
        private void tbAddress_Enter(object sender, EventArgs e)
        {
            if (tbAddress.Text == "Địa chỉ")
            {
                tbAddress.Text = "";
                tbAddress.ForeColor = Color.Black;
            }
        }
        private void tbAddress_Leave(object sender, EventArgs e)
        {
            if (tbAddress.Text == "")
            {
                tbAddress.Text = "Địa chỉ";
                tbAddress.ForeColor = Color.Gray;
            }
        }
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "example@gmail.com")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "example@gmail.com";
                tbEmail.ForeColor = Color.Gray;
            }
        }
        /*End placeholders*/
    }
}

