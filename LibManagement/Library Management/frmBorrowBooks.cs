﻿using System;
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
    public partial class frmBorrowBooks : Form
    {
        private BorrowBookBUS borrowBUS = new BorrowBookBUS();
        private ReaderBUS ReaderBUS = new ReaderBUS();
        public frmBorrowBooks()
        {
            InitializeComponent();
        }
        // To create placeholders
        private void tbIdBorrowBook_Enter(object sender, EventArgs e)
        {
            if (tbIdBorrowBook.Text == "Mã phiếu mượn")
            {
                tbIdBorrowBook.Text = "";
                tbIdBorrowBook.ForeColor = Color.Black;
            }
        }
        private void tbIdBorrowBook_Leave(object sender, EventArgs e)
        {
            if (tbIdBorrowBook.Text == "")
            {
                tbIdBorrowBook.Text = "Mã phiếu mượn";
                tbIdBorrowBook.ForeColor = Color.Gray;
            }
        }
        private void tbReaderCode_Enter(object sender, EventArgs e)
        {
            if (tbReaderCode.Text == "Mã độc giả")
            {
                tbReaderCode.Text = "";
                tbReaderCode.ForeColor = Color.Black;
            }
        }
        private void tbReaderCode_Leave(object sender, EventArgs e)
        {
            if (tbReaderCode.Text == "")
            {
                tbReaderCode.Text = "Mã độc giả";
                tbReaderCode.ForeColor = Color.Gray;
            }
        }
        private void tbBookCode_Enter(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "Mã sách cần mượn")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "")
            {
                tbBookCode.Text = "Mã sách cần mượn";
                tbBookCode.ForeColor = Color.Gray;
            }
        }

        private void tbReaderCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            QLTVDTO.borrowbook borrowDTO = new QLTVDTO.borrowbook();
            bookDTO book = new bookDTO();
            ReaderDTO reader = new ReaderDTO();
            DateTimePicker myPicker = new DateTimePicker();
            myPicker.Value = DateTime.Now;
            int k = myPicker.Value.Month - reader.DateCreateReader.Month ;
            int SoSachMuon = ReaderBUS.SoSachMuon(reader);
            int SoSachMax = ReaderBUS.getMaxofBorrowBook();
            reader.IdReader = int.Parse(tbReaderCode.Text);
            string temp = tbReaderCode.Text;
            if ( (k > ReaderBUS.getTimeofReader()) && (SoSachMuon > SoSachMax))
            {
                MessageBox.Show("Đã Hết hạn mượn Thẻ ");
            }
            else
            {
                
                book.MaSach = tbBookCode.Text;
                borrowDTO.NgayMuonSach = DateBorrowdtp.Value;
                borrowDTO.Idborrowbook = tbIdBorrowBook.Text;
                borrowDTO.NgayTraSach = DateBorrowdtp.Value.AddDays(borrowBUS.SoNgayMuonToiDa());
                
                //add into db
                bool result = borrowBUS.add(borrowDTO, book, reader);
                if (result == true)
                    MessageBox.Show("Mượn thành công");
                else
                    MessageBox.Show("Mượn thất bại");
            }


        }
      
        //end placeholders
    }
}
