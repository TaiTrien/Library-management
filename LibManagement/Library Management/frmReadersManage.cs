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
    public partial class frmReadersManage : Form
    {
        public frmReadersManage()
        {
            InitializeComponent();
        }
        // to create a form to add new readers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewReaders frmAddNewReaders = new frmAddNewReaders();
            frmAddNewReaders.ShowDialog();
        }
    }
}
