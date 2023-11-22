using BLL_DAL;
using CustomControl.FormCustom;
using FormControl;
using System;
using System.Windows.Forms;

namespace PTPM_QLMiCay.GUI
{
    public partial class fTrangChu : FormEntity
    {
        private TaiKhoan taiKhoan;

        UFTrangChu ufTrangChu = new UFTrangChu();
        UFNguyenLieu ufNguyenLieu = new UFNguyenLieu();
        UFNhanVIen ufNhanVien = new UFNhanVIen();
        UFNhaCungCap ufNhaCungCap = new UFNhaCungCap();
        UFDanhMuc ufDanhMuc = new UFDanhMuc();
        UFQuyen ufQuyen = new UFQuyen();
        UFBan ufBan = new UFBan();
        UFNhomQuyen ufNhomQuyen = new UFNhomQuyen();
        DAL_PhanQuyen dal_PhanQuyen = new DAL_PhanQuyen();

        public fTrangChu()
        {
            InitializeComponent();
        }

        public fTrangChu(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            lblNhanVien.Text = this.taiKhoan.NhanVien.NV_Ten;
        }
        public void OpenChildFormCT(UserControl childForm) 
        {
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(childForm);
            panel_Body.Dock = DockStyle.Fill;
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildFormCT(ufTrangChu);
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            OpenChildFormCT(ufTrangChu);
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            ufNguyenLieu = new UFNguyenLieu(taiKhoan);

            if(taiKhoan.TK_NguoiDung!="sa")
            {
                int id = dal_PhanQuyen.getQuyenID(taiKhoan.TK_NguoiDung, "MH_NL");

                if (id == 0 || id == 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông Báo");
                    ufNguyenLieu = null;
                }
                else if (id == 2)
                {
                    MessageBox.Show("Bạn không có quyền thao tác", "Thông Báo");

                    ufNguyenLieu.Enabled = false;
                }
                else
                    ufNguyenLieu.Enabled = true;
            }

            if (ufNguyenLieu != null)
            {
                OpenChildFormCT(ufNguyenLieu);
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ufNhaCungCap = new UFNhaCungCap(taiKhoan);
            if (taiKhoan.TK_NguoiDung != "sa")
            {
                int id = dal_PhanQuyen.getQuyenID(taiKhoan.TK_NguoiDung, "MH_NCC");

                if (id == 0 || id == 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông Báo");
                    ufNhaCungCap = null;
                }
                else if (id == 2)
                {
                    MessageBox.Show("Bạn không có quyền thao tác", "Thông Báo");

                    ufNhaCungCap.Enabled = false;
                }
                else
                    ufNhaCungCap.Enabled = true;
            }

            if (ufNhaCungCap != null)
            {
                OpenChildFormCT(ufNhaCungCap);
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ufDanhMuc = new UFDanhMuc();
            if (taiKhoan.TK_NguoiDung != "sa")
            {
                int id = dal_PhanQuyen.getQuyenID(taiKhoan.TK_NguoiDung, "MH_DM");

                if (id == 0 || id == 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông Báo");
                    ufDanhMuc = null;
                }
                else if (id == 2)
                {
                    MessageBox.Show("Bạn không có quyền thao tác", "Thông Báo");

                    ufDanhMuc.Enabled = false;
                }
                else
                    ufDanhMuc.Enabled = true;
            }

            if (ufDanhMuc != null)
            {
                OpenChildFormCT(ufDanhMuc);
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ufNhanVien = new UFNhanVIen();
            if (taiKhoan.TK_NguoiDung != "sa")
            {
                int id = dal_PhanQuyen.getQuyenID(taiKhoan.TK_NguoiDung, "MH_NV");

                if (id == 0 || id == 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông Báo");
                    ufNhanVien = null;
                }
                else if (id == 2)
                {
                    MessageBox.Show("Bạn không có quyền thao tác", "Thông Báo");

                    ufNhanVien.Enabled = false;
                }
                else
                    ufNhanVien.Enabled = true;
            }

            if (ufNhanVien != null)
            {
                OpenChildFormCT(ufNhanVien);
            }
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            ufQuyen = new UFQuyen();
            if (taiKhoan.TK_NguoiDung != "sa")
            {
                int id = dal_PhanQuyen.getQuyenID(taiKhoan.TK_NguoiDung, "MH_Q");

                if (id == 0 || id == 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông Báo");
                    ufQuyen = null;
                }
                else if (id == 2)
                {
                    MessageBox.Show("Bạn không có quyền thao tác", "Thông Báo");

                    ufQuyen.Enabled = false;
                }
                else
                    ufQuyen.Enabled = true;
            }

            if(ufQuyen!=null)
            {
                ufQuyen.ShowNhomQuyen += ShowNhomQuyen;
                OpenChildFormCT(ufQuyen);
            }

        }
        private void ShowNhomQuyen(object sender, EventArgs e)
        {
            OpenChildFormCT(ufNhomQuyen);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formDangNhap.Show();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenChildFormCT(ufBan);
        }
    }
}
