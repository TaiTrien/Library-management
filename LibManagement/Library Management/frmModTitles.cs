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

        public frmModTitles()
        {
            InitializeComponent();

        }
        private void loadAuthInto_ListBox()
        {
            List<authDTO> listAuth = authBUS.selectedAuth();
            if (lsbAuth == null)
            {
                MessageBox.Show("DB chưa có thông tin của bất cứ tác giả nào");
                return;
            }
            lsbAuth.DataSource = new BindingSource(listAuth, String.Empty);
            lsbAuth.DisplayMember = "TenTacGia";
            lsbAuth.ValueMember = "MaTacGia";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[lsbAuth.DataSource];
            myCurrencyManager.Refresh();

            if (lsbAuth.Items.Count > 0)
            {
                lsbAuth.SelectedIndex = 0;
            }

        }

        private void frmModTitles_Load(object sender, EventArgs e)
        {
            loadAuthInto_ListBox();
            authBUS = new authBUS();
        }
    }
}
