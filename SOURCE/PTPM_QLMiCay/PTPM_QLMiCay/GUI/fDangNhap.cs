using BLL_DAL;
using CustomControl.FormCustom;
using System;
using System.Windows.Forms;

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
                TaiKhoan tk = dal_TK.loadTaiKhoan(tenTK, mkTK);
                Program.formTrangChu = new fTrangChu(tk.TK_NguoiDung);
                Program.formDangNhap.Visible = false;
                Program.formTrangChu.ShowDialog();
            }
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
