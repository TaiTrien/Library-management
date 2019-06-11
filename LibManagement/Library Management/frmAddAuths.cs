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
    public partial class frmAddAuths : Form
    {
        
        private authBUS authBUS;
        private authDTO authDTO;
        public frmAddAuths()
        {
            InitializeComponent();
            
        }
        // To set placeholders
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
        private void tbAuthCode_Enter(object sender, EventArgs e)
        {
            if (tbAuthCode.Text == "Mã tác giả")
            {
                tbAuthCode.Text = "";
                tbAuthCode.ForeColor = Color.Black;
            }
        }
        private void tbAuthCode_Leave(object sender, EventArgs e)
        {
            if (tbAuthCode.Text == "")
            {
                tbAuthCode.Text = "Mã tác giả";
                tbAuthCode.ForeColor = Color.Gray;
            }
        }
        //To end placeholders
        public void btnAdd_Click(object sender, EventArgs e)
        {
           bool result;
          
                //map data from gui
                authDTO.MaTacGia = tbAuthCode.Text;
                authDTO.TenTacGia = tbName.Text;
                authDTO.NgaySinh = dtpDob.Value;

                //add into db
                result = authBUS.add(authDTO);
                if (result == false)
                    MessageBox.Show("Thêm thất bại.");
                else
                    MessageBox.Show("Thêm thành công.");
         
        }
       
        
        private void frmAddNewAuths_Load(object sender, EventArgs e)
        {
            authBUS = new authBUS();
            authDTO = new authDTO();
        }

     }
}
