using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace PTPM_QLMiCay.GUI
{
    public partial class fCauHinh : Form
    {
        DAL_QLNguoiDung ndDal = new DAL_QLNguoiDung();
        public fCauHinh()
        {
            InitializeComponent();
        }

        private void fCauHinh_Load(object sender, EventArgs e)
        {
            cboServer.DataSource = ndDal.getServerName();
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = ndDal.getDBName(cboServer.Text, txtUser.Text, txtMK.Text);
            cboDatabase.DisplayMember = "name";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ndDal.saveConfig(cboServer.Text, txtUser.Text, txtMK.Text, cboDatabase.Text);
            this.Close();
            if (Program.formDangNhap.IsDisposed || Program.formDangNhap == null)
            {
                Program.formDangNhap = new fDangNhap();
            }
            Program.formDangNhap.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Program.formDangNhap.IsDisposed || Program.formDangNhap == null)
            {
                Program.formDangNhap = new fDangNhap();
            }
            Program.formDangNhap.Show();
        }
    }
}
