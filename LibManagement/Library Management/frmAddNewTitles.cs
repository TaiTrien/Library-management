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
    public partial class frmAddNewTitles : Form
    {
        private titlesBUS titlesBUS;
        private typeBUS typeBUS;
        private authBUS authBUS;
        public frmAddNewTitles()
        {
            InitializeComponent();
        }
        // To create placeholders
        private void tbTitlesCode_Enter(object sender, EventArgs e)
        {
            if (tbTitlesCode.Text == "Mã đầu sách")
            {
                tbTitlesCode.Text = "";
                tbTitlesCode.ForeColor = Color.Black;
            }
        }
        private void tbTitlesCode_Leave(object sender, EventArgs e)
        {
            if (tbTitlesCode.Text == "")
            {
                tbTitlesCode.Text = "Mã đầu sách";
                tbTitlesCode.ForeColor = Color.Gray;
            }
        }
        private void tbTitlesName_Enter(object sender, EventArgs e)
        {
            if (tbTitlesName.Text == "Tên đầu sách")
            {
                tbTitlesName.Text = "";
                tbTitlesName.ForeColor = Color.Black;
            }
        }
        private void tbTitlesName_Leave(object sender, EventArgs e)
        {
            if (tbTitlesName.Text == "")
            {
                tbTitlesName.Text = "Tên đầu sách";
                tbTitlesName.ForeColor = Color.Gray;
            }
        }
        //end placeholders

        private void frmAddNewTitles_Load(object sender, EventArgs e)
        {
            titlesBUS = new titlesBUS();
            typeBUS = new typeBUS();
            authBUS = new authBUS();
            loadDataInto_ListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Map data from gui
            titlesDTO titlesDTO = new titlesDTO();
            titlesDTO.MaDauSach = tbTitlesCode.Text;
            titlesDTO.TenDauSach = tbTitlesName.Text;
            titlesDTO.MaTacGia = lsbAuth.SelectedValue.ToString();
            titlesDTO.TheLoai = lsbType.SelectedValue.ToString();
            
            //Add into DB
            bool result = titlesBUS.add(titlesDTO);
            if (result == true)
                MessageBox.Show("Thêm đầu sách thành công");
            else
                MessageBox.Show("Thêm đầu sách thất bại");
        }
        private void loadDataInto_ListBox()
        {
            List<authDTO> listAuth = authBUS.selectedAuth();
            List<typeDTO> listType = typeBUS.selectedTypes();
            if (lsbAuth == null)
            {
                MessageBox.Show("DB chưa có thông tin của bất cứ tác giả nào");
                return;
            }
            if (lsbType == null)
            {
                MessageBox.Show("DB chưa có thông tin của bất cứ thể loại nào");
                return;
            }
            lsbAuth.DataSource = new BindingSource(listAuth, String.Empty);
            lsbType.DataSource = new BindingSource(listType, String.Empty);

            lsbAuth.DisplayMember = "TenTacGia";
            lsbAuth.ValueMember = "MaTacGia";

            lsbType.DisplayMember = "tenTheLoai";
            lsbType.ValueMember = "maTheLoai";

            CurrencyManager myCurrencyManager1 = (CurrencyManager)this.BindingContext[lsbAuth.DataSource];
            myCurrencyManager1.Refresh();

            CurrencyManager myCurrencyManager2 = (CurrencyManager)this.BindingContext[lsbType.DataSource];
            myCurrencyManager2.Refresh();

            if (lsbAuth.Items.Count > 0)
            {
                lsbAuth.SelectedIndex = 0;
            }

            if (lsbType.Items.Count > 0)
            {
                lsbType.SelectedIndex = 0;
            }

        }
    }
}
