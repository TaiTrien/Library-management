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
    public partial class frmReadersManage : Form
    {
        private QLTVBUS.ReaderBUS dgBus;

        public frmReadersManage()
        {
            InitializeComponent();
            dgBus = new QLTVBUS.ReaderBUS();
        }
        // to create a form to add new readers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewReaders frmAddNewReaders = new frmAddNewReaders();
            frmAddNewReaders.ShowDialog();
            LoadDataInto_DataGridViewOfreader();
        }
        

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvDocGia.CurrentCell.RowIndex;

                ReaderDTO rd = new ReaderDTO();
                rd.IdReader = int.Parse(dgvDocGia.Rows[rowIndex].Cells[0].Value.ToString());
                bool kq = dgBus.delete(rd);
                if (kq == false)
                    MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                    MessageBox.Show("Xóa thành công");

            }
            else return;
            LoadDataInto_DataGridViewOfreader();

           
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Bạn có chắc chắn muốn sửa sách này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                int rowIndex = dgvDocGia.CurrentCell.RowIndex;

                ReaderDTO rd = new ReaderDTO();
                rd.IdReader = int.Parse(dgvDocGia.Rows[rowIndex].Cells[0].Value.ToString());
                rd.IdReader = int.Parse(dgvDocGia.Rows[rowIndex].Cells[0].Value.ToString());
                rd.NameReader = dgvDocGia.Rows[rowIndex].Cells[1].Value.ToString();
                rd.DateOfBirth = DateTime.Parse(dgvDocGia.Rows[rowIndex].Cells[2].Value.ToString());
                rd.AddressReader = dgvDocGia.Rows[rowIndex].Cells[3].Value.ToString();
                rd.Email = dgvDocGia.Rows[rowIndex].Cells[4].Value.ToString();
                rd.DateCreateReader = DateTime.Parse(dgvDocGia.Rows[rowIndex].Cells[5].Value.ToString());
                rd.TypeOfReader = dgvDocGia.Rows[rowIndex].Cells[6].Value.ToString();

                frmAddNewReaders frmAddNewReaders = new frmAddNewReaders();
                frmAddNewReaders.edit(rd);
                frmAddNewReaders.ShowDialog();

            }
            else return;
            LoadDataInto_DataGridViewOfreader();

        }       

        private void frmReadersManage_Load(object sender, EventArgs e)
        {
            dgBus = new QLTVBUS.ReaderBUS();
            LoadDataInto_DataGridViewOfreader();
        }

        private void LoadDataInto_DataGridViewOfreader()
        {
            List<ReaderDTO> listReader = dgBus.select();
            if (listReader == null)
            {
                MessageBox.Show("Chưa có thông tin sách");
            }


            dgvDocGia.Columns.Clear();
            dgvDocGia.DataSource = null;
            dgvDocGia.ReadOnly = true;
            dgvDocGia.AutoGenerateColumns = false;
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.DataSource = listReader;

            DataGridViewTextBoxColumn clreaderCode = new DataGridViewTextBoxColumn();
            clreaderCode.Name = "ReaderCode";
            clreaderCode.HeaderText = "Mã Thẻ";
            clreaderCode.DataPropertyName = "IdReader";
            dgvDocGia.Columns.Add(clreaderCode);

            DataGridViewTextBoxColumn clreadername = new DataGridViewTextBoxColumn();
            clreadername.Name = "readername";
            clreadername.HeaderText = "Họ và tên";
            clreadername.DataPropertyName = "NameReader";
            dgvDocGia.Columns.Add(clreadername);

            DataGridViewTextBoxColumn clreaderborn = new DataGridViewTextBoxColumn();
            clreaderborn.Name = "readerborn";
            clreaderborn.HeaderText = "Ngày Sinh";
            clreaderborn.DataPropertyName = "DateOfBirth";
            dgvDocGia.Columns.Add(clreaderborn);

            DataGridViewTextBoxColumn clreaderadresss = new DataGridViewTextBoxColumn();
            clreaderadresss.Name = "readeradresss";
            clreaderadresss.HeaderText = "Địa chỉ ";
            clreaderadresss.DataPropertyName = "AddressReader";
            dgvDocGia.Columns.Add(clreaderadresss);

            DataGridViewTextBoxColumn clreaderemail = new DataGridViewTextBoxColumn();
            clreaderemail.Name = "readeremail";
            clreaderemail.HeaderText = "Email";
            clreaderemail.DataPropertyName = "Email";
            dgvDocGia.Columns.Add(clreaderemail);

            DataGridViewTextBoxColumn clreadercreatedate = new DataGridViewTextBoxColumn();
            clreadercreatedate.Name = "ReaderCreateDate";
            clreadercreatedate.HeaderText = "Ngày Lập Thẻ";
            clreadercreatedate.DataPropertyName = "DateCreateReader";
            dgvDocGia.Columns.Add(clreadercreatedate);

            DataGridViewTextBoxColumn clreadertype = new DataGridViewTextBoxColumn();
            clreadertype.Name = "readertype";
            clreadertype.HeaderText = "Loại độc giả";
            clreadertype.DataPropertyName = "TypeOfReader";
            dgvDocGia.Columns.Add(clreadertype);

        }
    }
    
}
