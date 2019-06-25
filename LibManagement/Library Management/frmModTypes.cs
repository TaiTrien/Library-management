using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTVBUS;
using QLTVDTO;

namespace Library_Management
{
    public partial class frmModTypes : Form
    {
        private typeBUS typeBUS;
        public frmModTypes()
        {
            InitializeComponent();
        }
        // to create place holder
        private void tbTypeName_Enter(object sender, EventArgs e)
        {
            if (tbTypeName.Text == "Tên thể loại")
            {
                tbTypeName.Text = "";
                tbTypeName.ForeColor = Color.Gray;
            }
        }
        private void tbTypeName_Leave(object sender, EventArgs e)
        {
            if (tbTypeName.Text == "")
            {
                tbTypeName.Text = "Tên thể loại";
                tbTypeName.ForeColor = Color.Gray;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            typeDTO typeDTO = new typeDTO();
            //to map data from gui
            typeDTO.maTheLoai = tbTypeCode.Text;
            typeDTO.tenTheLoai = tbTypeName.Text;

            bool result = typeBUS.mod(typeDTO);
            if (result == true)
                MessageBox.Show("Sửa thể loại thành công");
            else
                MessageBox.Show("Sửa thể loại thất bại");
            
        }

        private void frmModTypes_Load(object sender, EventArgs e)
        {
            typeBUS = new typeBUS();
        }
    }
}
