using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControl.FormCustom;
using FormControl;

namespace PTPM_QLMiCay.GUI
{
    public partial class fTrangChu : FormEntity
    {
        UFTrangChu ufTrangChu = new UFTrangChu();
        //UFNguyenLieu ufNguyenLieu = new UFNguyenLieu();
        UFNhanVIen ufNhanVien = new UFNhanVIen();
        UFNhaCungCap ufNhaCungCap = new UFNhaCungCap();
        UFDanhMuc ufDanhMuc = new UFDanhMuc();
        UFQuyen ufQuyen = new UFQuyen();
        public fTrangChu()
        {
            InitializeComponent();
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
            //OpenChildFormCT(ufNguyenLieu);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildFormCT(ufNhaCungCap);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildFormCT(ufDanhMuc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildFormCT(ufNhanVien);
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            OpenChildFormCT(ufQuyen);
        }
    }
}
