using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTVDTO;
using QLTVBUS;
namespace Library_Management
{
    public partial class frmModAuths : Form
    {
        private authBUS authBUS;
        private authDTO authDTO;
        public frmModAuths()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result;
            //map data from gui
            authDTO.MaTacGia = tbAuthCode.Text;
            authDTO.TenTacGia = tbName.Text;
            authDTO.NgaySinh = dtpDob.Value;

            result = authBUS.mod(authDTO);
            if (result == false)
                MessageBox.Show("Sửa thất bại.");
            else
                MessageBox.Show("Sửa thành công.");

        }

        private void frmModAuths_Load(object sender, EventArgs e)
        {
            authBUS = new authBUS();
            authDTO = new authDTO();
        }
    }
}
