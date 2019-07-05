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
    public partial class frmAddNewReaders : Form
    {

        private QLTVBUS.ReaderBUS dgbus;

        private int idreaderedit;
        public frmAddNewReaders()
        {
            InitializeComponent();
            dgbus = new QLTVBUS.ReaderBUS();

        }
        private void FrmAddNewReaders_Load(object sender, EventArgs e)
        {


        }
        // To set placeholders for textboxs
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Họ tên")
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }
        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Họ tên";
                tbName.ForeColor = Color.Gray;
            }
        }
        private void cbTypeofReaders_Enter(object sender, EventArgs e)
        {
            if (cbTypeofReaders.Text == "Loại độc giả")
            {
                cbTypeofReaders.Text = "";
                cbTypeofReaders.ForeColor = Color.Black;
            }
        }
        private void cbTypeofReaders_Leave(object sender, EventArgs e)
        {
            if (cbTypeofReaders.Text == "")
            {
                cbTypeofReaders.Text = "Loại độc giả";
                cbTypeofReaders.ForeColor = Color.Gray;
            }
        }
        private void tbAddress_Enter(object sender, EventArgs e)
        {
            if (tbAddress.Text == "Địa chỉ")
            {
                tbAddress.Text = "";
                tbAddress.ForeColor = Color.Black;
            }
        }
        private void tbAddress_Leave(object sender, EventArgs e)
        {
            if (tbAddress.Text == "")
            {
                tbAddress.Text = "Địa chỉ";
                tbAddress.ForeColor = Color.Gray;
            }
        }
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "example@gmail.com")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "example@gmail.com";
                tbEmail.ForeColor = Color.Gray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            ReaderDTO dg = new ReaderDTO();

            dg.IdReader = rd.Next(1, 100);
            dg.NameReader = tbName.Text;
            dg.DateOfBirth = dtpDob.Value.Date;

            DateTimePicker myPicker = new DateTimePicker();
            myPicker.Value = DateTime.Now;
            int k = myPicker.Value.Year - dtpDob.Value.Year;
            if ((k > dgbus.getMaxAgeofReader()) || (k < dgbus.getMinAgeofReader()))
            {
                MessageBox.Show("Tuổi chưa phù hợp , vui lòng nhập lại");
                
            }
            else
            {
                dg.AddressReader = tbAddress.Text;
                dg.Email = tbEmail.Text;
                dg.TypeOfReader = cbTypeofReaders.GetItemText(cbTypeofReaders.SelectedItem);
                dg.DateCreateReader = dtpDateCreateCard.Value.Date;
                bool kq = dgbus.add(dg);
                if (kq == false)
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                    MessageBox.Show("Thêm thành công");
            }
        }
        public void edit(ReaderDTO dg)
        {
            tbName.Text = dg.NameReader;
            idreaderedit = dg.IdReader;
            dtpDob.Value = dg.DateOfBirth.Date;
            tbAddress.Text = dg.AddressReader ;
            tbEmail.Text = dg.Email ;
            dtpDateCreateCard.Value = dg.DateCreateReader.Date;
            cbTypeofReaders.Text = dg.TypeOfReader;
            btnAdd.Visible = false;
            btnEdit.Visible = true;

        }
        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTypeofReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReaderDTO dg = new ReaderDTO();
            dg.IdReader = idreaderedit;
            dg.NameReader = tbName.Text;
            dg.DateOfBirth = dtpDob.Value.Date;
            dg.AddressReader = tbAddress.Text;
            dg.Email = tbEmail.Text;
            dg.TypeOfReader = cbTypeofReaders.GetItemText(cbTypeofReaders.SelectedItem);
            dg.DateCreateReader = dtpDateCreateCard.Value.Date;
            bool kq = dgbus.edit(dg);
            if (kq == false)
                MessageBox.Show("Sửa thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sửa thành công");
        }

        private void frmAddNewReaders_Load_1(object sender, EventArgs e)
        {

        }

       

        /*End placeholders*/
    }
}

