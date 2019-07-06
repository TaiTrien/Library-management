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
    public partial class frmTitlesManage : Form
    {
        private titlesBUS titlesBUS;
        private titlesDTO titlesDTO;
        private authBUS authBUS;

        public frmTitlesManage()
        {
            InitializeComponent();
        }
       
        private void frmTitlesManage_Load(object sender, EventArgs e)
        {
            titlesBUS = new titlesBUS();
            LoadDataInto_DataGridViewOfTitle();
        }

        private void LoadDataInto_DataGridViewOfTitle()
        {
            List<titlesDTO> listTitles = titlesBUS.selectedTitle();
            if (listTitles == null)
            {
                MessageBox.Show("Chưa có thông tin đầu sách");
            }
            

            dgvTitlesManage.Columns.Clear();
            dgvTitlesManage.DataSource = null;
            dgvTitlesManage.ReadOnly = true;
            dgvTitlesManage.AutoGenerateColumns = false;
            dgvTitlesManage.AllowUserToAddRows = false;
            dgvTitlesManage.DataSource = listTitles;

            DataGridViewTextBoxColumn clTitlesCode = new DataGridViewTextBoxColumn();
            clTitlesCode.Name = "authCode";
            clTitlesCode.HeaderText = "Mã đầu sách";
            clTitlesCode.DataPropertyName = "MaDauSach";
            dgvTitlesManage.Columns.Add(clTitlesCode);

            DataGridViewTextBoxColumn clTitlesName = new DataGridViewTextBoxColumn();
            clTitlesName.Name = "titlesName";
            clTitlesName.HeaderText = "Tên đầu sách";
            clTitlesName.DataPropertyName = "TenDauSach";
            dgvTitlesManage.Columns.Add(clTitlesName);

            DataGridViewTextBoxColumn clSumTitles = new DataGridViewTextBoxColumn();
            clSumTitles.Name = "sumTitles";
            clSumTitles.HeaderText = "Tổng số lượng";
            clSumTitles.DataPropertyName = "TongSoLuongTrongKho"; // haven't counted amout of titles yet
            dgvTitlesManage.Columns.Add(clSumTitles);

            DataGridViewTextBoxColumn clBorrowedAmoutTitles = new DataGridViewTextBoxColumn();
            clBorrowedAmoutTitles.Name = "borrowedAmoutTitles";
            clBorrowedAmoutTitles.HeaderText = "Số lượng đã mượn";
            clBorrowedAmoutTitles.DataPropertyName = "SoLuotMuon"; // haven't counted amout of titles are being borrowed yet
            dgvTitlesManage.Columns.Add(clBorrowedAmoutTitles);

            DataGridViewTextBoxColumn clRemainingAmoutTitles = new DataGridViewTextBoxColumn();
            clRemainingAmoutTitles.Name = " remainingAmoutTitles";
            clRemainingAmoutTitles.HeaderText = "Số lượng còn lại"; 
            clRemainingAmoutTitles.DataPropertyName = "SoLuongConLai"; // haven't counted amout of titles are remaining yet
            dgvTitlesManage.Columns.Add(clRemainingAmoutTitles);
        }
        // to create a form to add new titles
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewTitles frmAddNewTitles = new frmAddNewTitles();
            frmAddNewTitles.ShowDialog();
            LoadDataInto_DataGridViewOfTitle();
        }
        // to delete a titles 
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn xóa đầu sách này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvTitlesManage.CurrentCell.RowIndex;

                titlesDTO = new titlesDTO();
                titlesDTO.MaDauSach = dgvTitlesManage.Rows[rowIndex].Cells[0].Value.ToString();
                titlesBUS.del(titlesDTO);

            }
            else return;
            LoadDataInto_DataGridViewOfTitle();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            authBUS = new authBUS();
            titlesDTO titleDTO = new titlesDTO();
            // to get MaDauSach
            int rowIndex = dgvTitlesManage.CurrentCell.RowIndex;
            titleDTO.MaDauSach = dgvTitlesManage.Rows[rowIndex].Cells[0].Value.ToString();
            titleDTO.TenDauSach = dgvTitlesManage.Rows[rowIndex].Cells[1].Value.ToString();
            //to get auth Code from DAUSACH_TACGIA
            //string authReferenceTitle = authBUS.selectedAuthReferenceToTitle(titlesDTO);

            frmModTitles frmMod = new frmModTitles();
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn sửa đầu sách này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                frmMod.tbTitlesCode.Text = titleDTO.MaDauSach;
                frmMod.tbTitlesName.Text = titleDTO.TenDauSach;
              //  MessageBox.Show(authReferenceTitle);
               // frmMod.lsbAuth.SelectedValue = authReferenceTitle;
                frmMod.tbTitlesCode.ReadOnly = true;

                frmMod.ShowDialog();
            }
            else return;
            LoadDataInto_DataGridViewOfTitle();
        }
    }
    }

