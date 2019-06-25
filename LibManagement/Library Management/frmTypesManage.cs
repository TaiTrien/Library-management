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
    public partial class frmTypesManage : Form
    {
        private typeBUS typeBUS;
        
        public frmTypesManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new book
            frmAddNewType frmAddNewType = new frmAddNewType();
            frmAddNewType.ShowDialog();
            LoadDataInto_DataGridViewOfType();
        }
        //to load data in to datagridview control
        private void LoadDataInto_DataGridViewOfType()
        {
            List<typeDTO> listTypes = typeBUS.selectedTypes();
            
            if (listTypes == null)
            {
                MessageBox.Show("Chưa có thông tin thể loại");
            }


            dgvTypesManage.Columns.Clear();
            dgvTypesManage.DataSource = null;
            dgvTypesManage.ReadOnly = true;
            dgvTypesManage.AutoGenerateColumns = false;
            dgvTypesManage.AllowUserToAddRows = false;
            dgvTypesManage.DataSource = listTypes;

            DataGridViewTextBoxColumn clTypeCode = new DataGridViewTextBoxColumn();
            clTypeCode.Name = "typeCode";
            clTypeCode.HeaderText = "Mã thể loại";
            clTypeCode.DataPropertyName = "maTheLoai";
            dgvTypesManage.Columns.Add(clTypeCode);

            DataGridViewTextBoxColumn clTypeName = new DataGridViewTextBoxColumn();
            clTypeName.Name = "typeName";
            clTypeName.HeaderText = "Tên thể loại";
            clTypeName.DataPropertyName = "tenTheLoai";
            dgvTypesManage.Columns.Add(clTypeName);
        }

        private void frmTypesManage_Load(object sender, EventArgs e)
        {
            typeBUS = new typeBUS();
            LoadDataInto_DataGridViewOfType();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvTypesManage.CurrentCell.RowIndex;

                typeDTO typeDTO = new typeDTO();
                typeDTO.maTheLoai = dgvTypesManage.Rows[rowIndex].Cells[0].Value.ToString();
                typeBUS.del(typeDTO);

            }
            else return;
            LoadDataInto_DataGridViewOfType();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            frmModTypes frmModTypes = new frmModTypes();
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn sửa thể loại này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvTypesManage.CurrentCell.RowIndex;

                typeDTO typeDTO = new typeDTO();
                typeDTO.maTheLoai = dgvTypesManage.Rows[rowIndex].Cells[0].Value.ToString();
                typeDTO.tenTheLoai = dgvTypesManage.Rows[rowIndex].Cells[1].Value.ToString();

                frmModTypes.tbTypeCode.Text = typeDTO.maTheLoai;
                frmModTypes.tbTypeName.Text = typeDTO.tenTheLoai;
                frmModTypes.tbTypeCode.ReadOnly = true;

                frmModTypes.ShowDialog();
            }
            else return;
            LoadDataInto_DataGridViewOfType();
        }
    }
}
