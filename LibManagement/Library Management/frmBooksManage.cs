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
        private titlesBUS titlesBUS;
        public frmBooksManage()
        {
            InitializeComponent();
        }
        private void frmBooksManage_Load_1(object sender, EventArgs e)
        {
            titlesBUS = new titlesBUS();
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
            clStatusbook.Name = "Status";
            clStatusbook.HeaderText = "Đã Mượn";
            clStatusbook.DataPropertyName = "TinhTrang";
            dgvBooksManage.Columns.Add(clStatusbook);
        }

        private void LoadTitlesInto_ComboBox(frmModBook frmModBook)
        {
            titlesBUS = new titlesBUS();
            List<titlesDTO> listTitles = titlesBUS.selectedTitleall();
            if (frmModBook.cbTitleName == null)
            {
                MessageBox.Show("DB chưa có thông tin của bất cứ đầu sách nào");
                return;
            }
            frmModBook.cbTitleName.DataSource = new BindingSource(listTitles, String.Empty);
            frmModBook.cbTitleName.DisplayMember = "TenDauSach";
            frmModBook.cbTitleName.ValueMember = "MaDauSach";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[frmModBook.cbTitleName.DataSource];
            myCurrencyManager.Refresh();

            if (frmModBook.cbTitleName.Items.Count > 0)
            {
                frmModBook.cbTitleName.SelectedIndex = 0;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new book
            frmAddNewBooks frmAddNewBooks = new frmAddNewBooks();
            frmAddNewBooks.ShowDialog();
            LoadDataInto_DataGridViewOfBook();
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
            LoadDataInto_DataGridViewOfBook();
        }
        // to create a form to return books
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturnBooks frmReturnBooks = new frmReturnBooks();
            frmReturnBooks.ShowDialog();
            LoadDataInto_DataGridViewOfBook();
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

        private void btnMod_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn sửa tác giả này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvBooksManage.CurrentCell.RowIndex;

                bookDTO = new bookDTO();
                bookDTO.MaSach = dgvBooksManage.Rows[rowIndex].Cells[0].Value.ToString();
                bookDTO.MaDauSach = dgvBooksManage.Rows[rowIndex].Cells[1].Value.ToString();
                bookDTO.NgayNhap = Convert.ToDateTime(dgvBooksManage.Rows[rowIndex].Cells[2].Value);
                bookDTO.NhaXuatBan = dgvBooksManage.Rows[rowIndex].Cells[3].Value.ToString();
                bookDTO.NamXuatBan = Convert.ToDateTime(dgvBooksManage.Rows[rowIndex].Cells[4].Value);
               // bookDTO.TriGia = Decimal.Parse(bookDTO.NhaXuatBan = dgvBooksManage.Rows[rowIndex].Cells[5].Value.ToString());
                bookDTO.TinhTrang = dgvBooksManage.Rows[rowIndex].Cells[6].Value.ToString();

                // to display form to modify author
                frmModBook frmModBook = new frmModBook();
                LoadTitlesInto_ComboBox(frmModBook);
                frmModBook.tbBookCode.ReadOnly = true;
                frmModBook.tbBookCode.Text=bookDTO.MaSach;
                frmModBook.cbTitleName.SelectedValue = bookDTO.MaDauSach;
                frmModBook.dtpDateIn.Value = bookDTO.NgayNhap;
                frmModBook.dtpPublishYear.Value = bookDTO.NamXuatBan;
                frmModBook.tbPublisher.Text = bookDTO.NhaXuatBan ;
                frmModBook.nudValue.Value = bookDTO.TriGia ;
                frmModBook.ShowDialog();
            }
            else return;
            LoadDataInto_DataGridViewOfBook();
        }
    }
}
