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
    public partial class frmMainMenu : Form
    {
        Form frmParent;
        public frmMainMenu()
        {
            InitializeComponent();
            frmParent = ParentForm;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            //To create & add menu books to main menu
            this.lbMessage.Hide();
            frmMenuBooks frmMenuBooks = new frmMenuBooks();
            frmMenuBooks.TopLevel = false;
            this.pnDisplay.Controls.Clear();
            this.pnDisplay.Controls.Add(frmMenuBooks);
            frmMenuBooks.Show();
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            //To create & add menu readers to main menu
            this.lbMessage.Hide();
            frmReadersManage frmReadersManage = new frmReadersManage();
            frmReadersManage.TopLevel = false;
            this.pnDisplay.Controls.Clear();
            this.pnDisplay.Controls.Add(frmReadersManage);
            frmReadersManage.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // to create & add menu reports to main menu
            this.lbMessage.Hide();
            frmMenuReports frmMenuReports = new frmMenuReports();
            frmMenuReports.TopLevel = false;
            this.pnDisplay.Controls.Clear();
            this.pnDisplay.Controls.Add(frmMenuReports);
            frmMenuReports.Show();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
