using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Library_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
            frmMainMenu.FormClosed += new FormClosedEventHandler(frmMainMenu_FormClosed);
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void pbX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // To set placeholders
        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "USER NAME")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.White;
            }
        }
        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "USER NAME";
                tbUserName.ForeColor = Color.Gray;
            }
        }
     
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "PASSWORD")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.White;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "PASSWORD";
                tbPassword.ForeColor = Color.Gray;
            }
        }

       
        //end placeholders
    }
}
