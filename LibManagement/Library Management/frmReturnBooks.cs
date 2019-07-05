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
    public partial class frmReturnBooks : Form
    {
        private BorrowBookBUS returnBUS = new BorrowBookBUS();

        public frmReturnBooks()
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
            if (tbBookCode.Text == "Mã sách cần trả")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbReaderCode.Text == "")
            {
                tbReaderCode.Text = "Mã sách cần trả";
                tbReaderCode.ForeColor = Color.Gray;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            QLTVDTO.borrowbook borrowDTO = new QLTVDTO.borrowbook();
            bookDTO book = new bookDTO();
            ReaderDTO reader = new ReaderDTO();

            book.MaSach = tbBookCode.Text;
            reader.IdReader = int.Parse(tbReaderCode.Text);
            borrowDTO.NgayTraSach = dtpReturnBookDate.Value;
            borrowDTO.Idborrowbook = tbReturnBook.Text;

            //add into db
            bool result = returnBUS.Tra(borrowDTO, book, reader);
            if (result == true)
                MessageBox.Show("Trả thành công");
            else
                MessageBox.Show("Trả sách thất bại");

        }

        private void tbReturnBook_TextChanged(object sender, EventArgs e)
        {

        }
        //end placeholders
    }
}
