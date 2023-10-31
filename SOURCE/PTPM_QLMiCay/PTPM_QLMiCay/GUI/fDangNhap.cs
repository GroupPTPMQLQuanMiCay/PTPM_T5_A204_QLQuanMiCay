using CustomControl.FormCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace PTPM_QLMiCay.GUI
{
    public partial class fDangNhap : FormEntity
    {
        DAL_TaiKhoan dal_TK = new DAL_TaiKhoan();
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void cButtonClose1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            string tenTK = txt_TenDN.Text.ToString();
            string mkTK = txt_MK.Text.ToString();

            int rs = dal_TK.checkTaiKhoan(tenTK, mkTK);
            if (rs == -1)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông Báo");
            }
            else if (rs == -2)
            {
                MessageBox.Show("Sai mật khẩu", "Thông Báo");
            }
            else
            {
                //Chua phan quyen
                if (Program.formTrangChu == null || Program.formTrangChu.IsDisposed)
                    Program.formTrangChu = new fTrangChu();
                Program.formDangNhap.Visible = false;
                Program.formTrangChu.Show();
            }
            
        }

        private void fDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formDangNhap.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
