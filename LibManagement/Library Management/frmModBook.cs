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
    public partial class frmModBook : Form
    {
        private bookBUS bookBUS;
        private bookDTO bookDTO;
        public frmModBook()
        {
            InitializeComponent();
            bookBUS = new bookBUS();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //map data from gui
        
            DateTimePicker myPicker = new DateTimePicker();
            myPicker.Value = DateTime.Now;
            int k = myPicker.Value.Year - dtpPublishYear.Value.Year;
            if (k > bookBUS.getMaxOfYearExp())
            {
                MessageBox.Show("Năm xuất bản không phù hợp");

            }
            else
            {
                bookDTO.MaSach = tbBookCode.Text;
                bookDTO.MaDauSach = cbTitleName.SelectedValue.ToString();
                bookDTO.NgayNhap = dtpDateIn.Value;
                bookDTO.NamXuatBan = dtpPublishYear.Value;
                bookDTO.NhaXuatBan = tbPublisher.Text;
                bookDTO.TriGia = nudValue.Value;
                bookDTO.TinhTrang = "0";


                //add into db
                bool result = bookBUS.mod(bookDTO);
                if (result == true)
                    MessageBox.Show("Sửa sách thành công");
                else
                    MessageBox.Show("Sửa sách thất bại");
            }
        }

        private void frmModBook_Load(object sender, EventArgs e)
        {
            bookDTO = new bookDTO();
        }
    }
}
