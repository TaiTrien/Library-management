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
    public partial class frmSearchBooks : Form
    {
        public frmSearchBooks()
        {
            InitializeComponent();
        }
        // To set placeholder
        private void tbSearchBar_Enter(object sender, EventArgs e)
        {
            if (tbSearchBar.Text == "Tìm kiếm....")
            {
                tbSearchBar.Text = "";
                tbSearchBar.ForeColor = Color.Black;
            }
        }
        private void tbSearchBar_Leave(object sender, EventArgs e)
        {
            if (tbSearchBar.Text == "")
            {
                tbSearchBar.Text = "Tìm kiếm....";
                tbSearchBar.ForeColor = Color.Gray;
            }
        }
        // end place holder
    }
}
