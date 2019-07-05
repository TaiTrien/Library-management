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
    public partial class frmBorrowBooks : Form
    {
        private BorrowBookBUS borrowBUS = new BorrowBookBUS();

        public frmBorrowBooks()
        {
            InitializeComponent();
        }
        // To create placeholders
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

            book.MaSach = tbBookCode.Text;
            reader.IdReader = int.Parse(tbReaderCode.Text);
            borrowDTO.NgayMuonSach = DateBorrowdtp.Value;
            borrowDTO.Idborrowbook = tbIdBorrowBook.Text;


            //add into db
            bool result = borrowBUS.add(borrowDTO,book,reader);
            if (result == true)
                MessageBox.Show("Thêm sách thành công");
            else
                MessageBox.Show("Thêm sách thất bại");



        }
        private void tbIdBorrowBook_Enter(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "Mã Mượn")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbIdBorrowBook_Leave(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "")
            {
                tbBookCode.Text = "Mã Mượn";
                tbBookCode.ForeColor = Color.Gray;
            }
        }
        //end placeholders
    }
}
