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
    public partial class frmAuthsManage : Form
    {
        private authBUS authBUS;
        private authDTO authDTO;
        public frmAuthsManage()
        {
            InitializeComponent();
        }

        

        private void frmAuthsManage_Load(object sender, EventArgs e)
        {
            authBUS = new authBUS();
            LoadDataInto_DatagridViewOfAuth();
        }
        // to load data into datagrid view
        private void LoadDataInto_DatagridViewOfAuth()
        {
            List<authDTO> listAuth = authBUS.selectedAuth();
            if (listAuth == null)
            {
                MessageBox.Show("Chưa có thông tin trong DB của tác giả");
                return;
            }

            dgvAuthManage.Columns.Clear();
            dgvAuthManage.DataSource = null;
            dgvAuthManage.ReadOnly = true;
            dgvAuthManage.AutoGenerateColumns = false;
            dgvAuthManage.AllowUserToAddRows = false;
            dgvAuthManage.DataSource = listAuth;

            DataGridViewTextBoxColumn clAuthCode = new DataGridViewTextBoxColumn();
            clAuthCode.Name = "authCode";
            clAuthCode.HeaderText = "Mã tác giả";
            clAuthCode.DataPropertyName = "MaTacGia";
            dgvAuthManage.Columns.Add(clAuthCode);

            DataGridViewTextBoxColumn clAuthName = new DataGridViewTextBoxColumn();
            clAuthName.Name = "authName";
            clAuthName.HeaderText = "Họ tên";
            clAuthName.DataPropertyName = "TenTacGia";
            dgvAuthManage.Columns.Add(clAuthName);

            DataGridViewTextBoxColumn clAuthDOB = new DataGridViewTextBoxColumn();
            clAuthDOB.Name = "authDOB";
            clAuthDOB.HeaderText = "Ngày sinh";
            clAuthDOB.DataPropertyName = "NgaySinh";
            dgvAuthManage.Columns.Add(clAuthDOB);
        }
        //to add a new author
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new auth
            frmAddAuths frmAddNewAuths = new frmAddAuths();
            frmAddNewAuths.ShowDialog();
            LoadDataInto_DatagridViewOfAuth();
        }
        // to del an author
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult(); 
            warning = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Cảnh báo!", MessageBoxButtons.YesNo); 
            if (warning == DialogResult.Yes) 
            {
                int rowIndex = dgvAuthManage.CurrentCell.RowIndex;

                authDTO = new authDTO();
                authDTO.MaTacGia = dgvAuthManage.Rows[rowIndex].Cells[0].Value.ToString();
                authBUS.del(authDTO);
               
            }
            else return;
            LoadDataInto_DatagridViewOfAuth();
        }
        // to modify an author
        private void btnMod_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn sửa tác giả này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvAuthManage.CurrentCell.RowIndex;
                
                authDTO = new authDTO();
                authDTO.MaTacGia = dgvAuthManage.Rows[rowIndex].Cells[0].Value.ToString();
                authDTO.TenTacGia = dgvAuthManage.Rows[rowIndex].Cells[1].Value.ToString();
                authDTO.NgaySinh= Convert.ToDateTime(dgvAuthManage.Rows[rowIndex].Cells[2].Value);
               
                // to display form to modify author
                frmModAuths frmModAuths = new frmModAuths();
                frmModAuths.tbAuthCode.Text = authDTO.MaTacGia;
                frmModAuths.tbAuthCode.ReadOnly = true;
                frmModAuths.tbName.Text = authDTO.TenTacGia;
                frmModAuths.dtpDob.Value = authDTO.NgaySinh;
                frmModAuths.ShowDialog();
            }
            else return;
            LoadDataInto_DatagridViewOfAuth();
        }
    }
}
