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
    public partial class frmAddNewBooks : Form
    {
        private bookBUS addBookBUS;
        private titlesBUS titlesBUS;
        public frmAddNewBooks()
        {
            InitializeComponent();
            //to custom date of numbericupdown
            nudValue.Value = (decimal)nudValue.Value;
        }

        // To set placeholders for textboxs
       

        private void tbBookCode_Enter(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "Mã sách")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "")
            {
                tbBookCode.Text = "Mã sách";
                tbBookCode.ForeColor = Color.Gray;
            }
        }
       
        private void tbPublisher_Enter(object sender, EventArgs e)
        {
            if (tbPublisher.Text == "Nhà xuất bản")
            {
                tbPublisher.Text = "";
                tbPublisher.ForeColor = Color.Black;
            }
        }
        private void tbPublisher_Leave(object sender, EventArgs e)
        {
            if (tbPublisher.Text == "")
            {
                tbPublisher.Text = "Nhà xuất bản";
                tbPublisher.ForeColor = Color.Gray;
            }
        }
        /*End placeholders*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //map data from gui
            bookDTO addBookDTO = new bookDTO();

            addBookDTO.MaSach = tbBookCode.Text;
            addBookDTO.MaDauSach = cbTitleName.SelectedValue.ToString();
            addBookDTO.NgayNhap = dtpDateIn.Value;
            addBookDTO.NamXuatBan = dtpPublishYear.Value;
            addBookDTO.NhaXuatBan = tbPublisher.Text;
            addBookDTO.TriGia = nudValue.Value;

            //add into db
            bool result = addBookBUS.add(addBookDTO);
            if ( result == true)
                MessageBox.Show("Thêm sách thành công");
            else
                MessageBox.Show("Thêm sách thất bại");
        }

        private void frmAddNewBooks_Load(object sender, EventArgs e)
        {
            addBookBUS = new bookBUS();
            titlesBUS = new titlesBUS();
            LoadTitlesInto_ComboBox();
        }

        private void LoadTitlesInto_ComboBox()
        {
            List<titlesDTO> listTitles = titlesBUS.selectedTitle();
            if (cbTitleName == null)
            {
                MessageBox.Show("DB chưa có thông tin của bất cứ đầu sách nào");
                return;
            }
            cbTitleName.DataSource = new BindingSource(listTitles, String.Empty);
            cbTitleName.DisplayMember = "TenDauSach";
            cbTitleName.ValueMember = "MaDauSach";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbTitleName.DataSource];
            myCurrencyManager.Refresh();

            if (cbTitleName.Items.Count > 0)
            {
                cbTitleName.SelectedIndex = 0;
            }
        }

    }
}
