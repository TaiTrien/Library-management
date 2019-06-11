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
    public partial class frmRPBorrowedBooks : Form
    {
        public frmRPBorrowedBooks()
        {
            InitializeComponent();
            //Custom date time pick to display only month
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "mmmm";
            dtpMonth.ShowUpDown = true;
           
            //Custom date time pick to display only year
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
        }
    }
}
