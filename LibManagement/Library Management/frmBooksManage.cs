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
    public partial class frmBooksManage : Form
    {
        private QLTVBUS.bookBUS bookBUS = new bookBUS();
        private bookDTO bookDTO;
        public frmBooksManage()
        {
            InitializeComponent();
        }
        private void frmBooksManage_Load_1(object sender, EventArgs e)
        {
            bookBUS = new QLTVBUS.bookBUS();
            LoadDataInto_DataGridViewOfBook();
        }

        private void LoadDataInto_DataGridViewOfBook()
        {

            List<bookDTO> listBook = bookBUS.selectedBook();
            if (listBook == null)
            {
                MessageBox.Show("Chưa có thông tin sách");
            }

            
            dgvBooksManage.Columns.Clear();
            dgvBooksManage.DataSource = null;
            dgvBooksManage.ReadOnly = true;
            dgvBooksManage.AutoGenerateColumns = false;
            dgvBooksManage.AllowUserToAddRows = false;
            dgvBooksManage.DataSource = listBook;

            DataGridViewTextBoxColumn clbookCode = new DataGridViewTextBoxColumn();
            clbookCode.Name = "bookCode";
            clbookCode.HeaderText = "Mã sách";
            clbookCode.DataPropertyName = "MaSach";
            dgvBooksManage.Columns.Add(clbookCode);

            DataGridViewTextBoxColumn cltitleCode = new DataGridViewTextBoxColumn();
            cltitleCode.Name = "TitleCode";
            cltitleCode.HeaderText = "Mã đầu sách";
            cltitleCode.DataPropertyName = "MaDauSach";
            dgvBooksManage.Columns.Add(cltitleCode);

            DataGridViewTextBoxColumn clbookDateImport = new DataGridViewTextBoxColumn();
            clbookDateImport.Name = "DateImport";
            clbookDateImport.HeaderText = "Ngày Nhập";
            clbookDateImport.DataPropertyName = "NgayNhap"; 
            dgvBooksManage.Columns.Add(clbookDateImport);

            DataGridViewTextBoxColumn clPublishCopbook = new DataGridViewTextBoxColumn();
            clPublishCopbook.Name = "Publishingbook";
            clPublishCopbook.HeaderText = "Nhà Xuất Bản";
            clPublishCopbook.DataPropertyName = "NhaXuatBan"; 
            dgvBooksManage.Columns.Add(clPublishCopbook);

            DataGridViewTextBoxColumn clDatePublishbook = new DataGridViewTextBoxColumn();
            clDatePublishbook.Name = " DatePublishbook";
            clDatePublishbook.HeaderText = "Ngày Xuất bản Sách ";
            clDatePublishbook.DataPropertyName = "NamXuatBan"; 
            dgvBooksManage.Columns.Add(clDatePublishbook);

            DataGridViewTextBoxColumn clPricebook = new DataGridViewTextBoxColumn();
            clPricebook.Name = "Pricebook";
            clPricebook.HeaderText = "Giá";
            clPricebook.DataPropertyName = "TriGia";
            dgvBooksManage.Columns.Add(clPricebook);

            DataGridViewTextBoxColumn clStatusbook = new DataGridViewTextBoxColumn();
            clPricebook.Name = "Status";
            clPricebook.HeaderText = "Đã Mượn";
            clPricebook.DataPropertyName = "TinhTrang";
            dgvBooksManage.Columns.Add(clStatusbook);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new book
            frmAddNewBooks frmAddNewBooks = new frmAddNewBooks();
            frmAddNewBooks.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // to create form to search books
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.ShowDialog();
        }

        //to create form to borrow books
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrowBooks frmBorrowBooks = new frmBorrowBooks();
            frmBorrowBooks.ShowDialog();
        }
        // to create a form to return books
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturnBooks frmReturnBooks = new frmReturnBooks();
            frmReturnBooks.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvBooksManage.CurrentCell.RowIndex;

                bookDTO = new bookDTO();
                bookDTO.MaSach = dgvBooksManage.Rows[rowIndex].Cells[0].Value.ToString();
                bookBUS.del(bookDTO);

            }
            else return;
            LoadDataInto_DataGridViewOfBook();
        }

       
    }
}
