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
    public partial class frmAddNewType : Form
    {
        private typeBUS typeBUS;
        public frmAddNewType()
        {
            InitializeComponent();
        }
        // to create place holders 
        private void tbTypeCode_Enter(object sender, EventArgs e)
        {
            if (tbTypeCode.Text == "Mã thể loại")
            {
                tbTypeCode.Text = "";
                tbTypeCode.ForeColor = Color.Black;
            }
        }
        private void tbTypeCode_Leave(object sender, EventArgs e)
        {
            if (tbTypeCode.Text == "")
            {
                tbTypeCode.Text = "Mã thể loại";
                tbTypeCode.ForeColor = Color.Gray;
            }
        }

        private void tbTypeName_Enter(object sender, EventArgs e)
        {
            if (tbTypeName.Text == "Tên thể loại")
            {
                tbTypeName.Text = "";
                tbTypeName.ForeColor = Color.Black;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int maxType = typeBUS.getMaxNumberofType();
            int temp = typeBUS.getNumberofType(); // to get present number of type 
            if (temp >= maxType && maxType!=0)
            {
                MessageBox.Show("Số lượng thể loại đã lớn hơn số qui định");
                return;
            }
            else 
            {
                typeDTO typeDTO = new typeDTO();
                //to map data from gui
                typeDTO.maTheLoai = tbTypeCode.Text;
                typeDTO.tenTheLoai = tbTypeName.Text;

                bool result = typeBUS.add(typeDTO);
                if (result == true)
                    MessageBox.Show("Thêm thể loại thành công");
                else
                    MessageBox.Show("Thêm thể loại thất bại");
            }
        }

        private void frmAddNewType_Load(object sender, EventArgs e)
        {
            typeBUS = new typeBUS();
        }
    }
}
