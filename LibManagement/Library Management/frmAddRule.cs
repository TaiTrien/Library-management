using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVDTO;
using QLTVBUS;

namespace Library_Management
{
    public partial class frmAddRule : Form
    {
        private ParameterBUS paraBUS;
        parametersDTO para = new parametersDTO();
        public frmAddRule()
        {
            InitializeComponent();
            paraBUS = new ParameterBUS();
            
            para = paraBUS.Selected();
            tbMinAgeReader.Text = para.TuoiToiThieuDocGia.ToString();
            tbMaxAgeReader.Text = para.TuoiToiDaDocGia.ToString();
            txTimeExpReader.Text = para.ThoiHanThe.ToString();
            txNumberTitles.Text = para.SoTheLoaiToiDa.ToString();
            tbYearPubish.Text = para.NamXuatBanToiDa.ToString();
            tbMaxBookBorrow.Text = para.SoSachMuonToiDa.ToString();
            tbMaxDayBorrow.Text = para.SoNgayMuonToiDa.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnYearPublish_Click(object sender, EventArgs e)
        {

        }

        private void tbMinAgeReader_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMinAgeReader_Enter(object sender, EventArgs e)
        {
            if (tbMinAgeReader.Text == para.TuoiToiThieuDocGia.ToString())
            {
                tbMinAgeReader.Text = "";
                tbMinAgeReader.ForeColor = Color.Black;
            }
        }

        private void tbMinAgeReader_Leave(object sender, EventArgs e)
        {
            if (tbMinAgeReader.Text == "")
            {
                tbMinAgeReader.Text = para.TuoiToiThieuDocGia.ToString() ;
                tbMinAgeReader.ForeColor = Color.Gray;
            }
        }

        private void tbMaxAgeReader_Enter(object sender, EventArgs e)
        {
            if (tbMaxAgeReader.Text == para.TuoiToiDaDocGia.ToString())
            {
                tbMaxAgeReader.Text = "";
                tbMaxAgeReader.ForeColor = Color.Black;
            }
        }

        private void tbMaxAgeReader_Leave(object sender, EventArgs e)
        {
            if (tbMaxAgeReader.Text == "")
            {
                tbMaxAgeReader.Text = para.TuoiToiDaDocGia.ToString();
                tbMaxAgeReader.ForeColor = Color.Gray;
            }
        }

        private void txTimeExpReader_Enter(object sender, EventArgs e)
        {
            if (txTimeExpReader.Text == para.ThoiHanThe.ToString())
            {
                txTimeExpReader.Text = "";
                txTimeExpReader.ForeColor = Color.Black;
            }
        }

        private void txTimeExpReader_Leave(object sender, EventArgs e)
        {
            if (txTimeExpReader.Text == "")
            {
                txTimeExpReader.Text = para.ThoiHanThe.ToString();
                txTimeExpReader.ForeColor = Color.Gray;
            }
        }

        private void txNumberTitles_Leave(object sender, EventArgs e)
        {
            if (txNumberTitles.Text == "")
            {
                txNumberTitles.Text = para.SoTheLoaiToiDa.ToString();
                txNumberTitles.ForeColor = Color.Gray;
            }
        }

        private void txNumberTitles_Enter(object sender, EventArgs e)
        {
            if (txNumberTitles.Text == para.SoTheLoaiToiDa.ToString())
            {
                txNumberTitles.Text = "";
                txNumberTitles.ForeColor = Color.Black;
            }
        }

        private void tbYearPubish_Enter(object sender, EventArgs e)
        {
            if (tbYearPubish.Text == para.NamXuatBanToiDa.ToString())
            {
                tbYearPubish.Text = "";
                tbYearPubish.ForeColor = Color.Black;
            }
        }

        private void tbYearPubish_Leave(object sender, EventArgs e)
        {
            if (tbYearPubish.Text == "")
            {
                tbYearPubish.Text = para.NamXuatBanToiDa.ToString();
                tbYearPubish.ForeColor = Color.Gray;
            }
        }

        private void tbMaxBookBorrow_Leave(object sender, EventArgs e)
        {
            if (tbMaxBookBorrow.Text == "")
            {
                tbMaxBookBorrow.Text = para.SoSachMuonToiDa.ToString();
                tbMaxBookBorrow.ForeColor = Color.Gray;
            }
        }

        private void tbMaxBookBorrow_Enter(object sender, EventArgs e)
        {
            if (tbMaxBookBorrow.Text == para.SoSachMuonToiDa.ToString())
            {
                tbMaxBookBorrow.Text = "";
                tbMaxBookBorrow.ForeColor = Color.Black;
            }
        }

        private void tbMinBookBorrow_Enter(object sender, EventArgs e)
        {
            if (tbMaxDayBorrow.Text == para.SoNgayMuonToiDa.ToString())
            {
                tbMaxDayBorrow.Text = "";
                tbMaxDayBorrow.ForeColor = Color.Black;
            }
        }

        private void tbMaxDayBorrow_Leave(object sender, EventArgs e)
        {
            if (tbMaxDayBorrow.Text == "")
            {
                tbMaxDayBorrow.Text = para.SoNgayMuonToiDa.ToString();
                tbMaxDayBorrow.ForeColor = Color.Gray;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result;
            //map data from gui
            para.TuoiToiThieuDocGia = int.Parse(tbMinAgeReader.Text);
            para.TuoiToiDaDocGia = int.Parse(tbMaxAgeReader.Text);
            para.ThoiHanThe = int.Parse(txTimeExpReader.Text);
            para.SoTheLoaiToiDa = int.Parse(txNumberTitles.Text);
            para.NamXuatBanToiDa = int.Parse(tbYearPubish.Text);
            para.SoSachMuonToiDa = int.Parse(tbMaxBookBorrow.Text);
            para.SoNgayMuonToiDa = int.Parse(tbMaxDayBorrow.Text);

            result = paraBUS.edit(para);
            if (result == false)
                MessageBox.Show("Sửa thất bại.");
            else
                MessageBox.Show("Sửa thành công.");
        }
    }
}
