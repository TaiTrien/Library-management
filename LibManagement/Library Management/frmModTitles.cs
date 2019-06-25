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
    public partial class frmModTitles : Form
    {
        private authBUS authBUS;
        private typeBUS typeBUS;
        private titlesDTO titlesDTO;
        private titlesBUS titleBUS;
        public frmModTitles()
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
        private void loadAuthInto_ListBox()
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
                MessageBox.Show("DB chưa có thông tin của bất cứ tác giả nào");
                return;
            }
            lsbAuth.DataSource = new BindingSource(listAuth, String.Empty);
            lsbAuth.DisplayMember = "TenTacGia";
            lsbAuth.ValueMember = "MaTacGia";

            lsbType.DataSource = new BindingSource(listType, String.Empty);
            lsbType.DisplayMember = "TenTheLoai";
            lsbType.ValueMember = "MaTheLoai";


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[lsbAuth.DataSource];
            myCurrencyManager.Refresh();

            if (lsbAuth.Items.Count > 0)
            {
                lsbAuth.SelectedIndex = 0;
            }

        }

        private void frmModTitles_Load(object sender, EventArgs e)
        {
            authBUS = new authBUS();
            titleBUS = new titlesBUS();
            typeBUS = new typeBUS();
            loadDataIntoForm();
            loadAuthInto_ListBox();
        }
        private void loadDataIntoForm()
        {
            titlesDTO = new titlesDTO();
            
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            bool result;
            //map data from gui
            titlesDTO.MaDauSach = tbTitlesCode.Text;
            titlesDTO.TenDauSach = tbTitlesName.Text;
            titlesDTO.MaTacGia = lsbAuth.SelectedValue.ToString();
            titlesDTO.TheLoai = lsbType.SelectedValue.ToString();

            result = titleBUS.mod(titlesDTO);
            if (result == false)
                MessageBox.Show("Sửa thất bại.");
            else
                MessageBox.Show("Sửa thành công.");
        }
    }
}
