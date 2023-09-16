using CustomControl.FormCustom;
using FormControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTPM_QLMiCay.GUI
{
    public partial class fTrangChu : FormEntity
    {
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ufNguyenLieu1_Load(object sender, EventArgs e)
        {

        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            ufTrangChu1.Show();
            ufNguyenLieu1.Hide();
            ufNhaCungCap1.Hide();
            ufDanhMuc1.Hide();
            ufNhanVIen1.Hide();
        }

        private void cButtonFlat1_Click(object sender, EventArgs e)
        {
            //Hide other user control
            ufNguyenLieu1.Hide();
            ufNhaCungCap1.Hide();
            ufDanhMuc1.Hide();
            ufNhanVIen1.Hide();
            //Show current usercontrol
            ufTrangChu1.Show();
            ufTrangChu1.BringToFront();
        }

        private void cButtonFlat2_Click(object sender, EventArgs e)
        {
            //Hide other user control
            ufTrangChu1.Hide();
            ufNhaCungCap1.Hide();
            ufDanhMuc1.Hide();
            ufNhanVIen1.Hide();
            //Show current usercontrol
            ufNguyenLieu1.Show();
            ufNguyenLieu1.BringToFront();
        }

        private void cButtonFlat3_Click(object sender, EventArgs e)
        {
            //Hide other user control
            ufTrangChu1.Hide();
            ufDanhMuc1.Hide();
            ufNguyenLieu1.Hide();
            ufNhanVIen1.Hide();
            //Show current usercontrol
            ufNhaCungCap1.Show();
            ufNhaCungCap1.BringToFront();
        }

        private void cButtonFlat4_Click(object sender, EventArgs e)
        {
            //Hide other user control
            ufTrangChu1.Hide();
            ufNhaCungCap1.Hide();
            ufNguyenLieu1.Hide();
            ufNhanVIen1.Hide();
            //Show current usercontrol
            ufDanhMuc1.Show();
            ufDanhMuc1.BringToFront();
        }

        private void cButtonFlat5_Click(object sender, EventArgs e)
        {
            //Hide other user control
            ufTrangChu1.Hide();
            ufNhaCungCap1.Hide();
            ufNguyenLieu1.Hide();
            ufDanhMuc1.Hide();
            //Show current usercontrol
            ufNhanVIen1.Show();
            ufNhanVIen1.BringToFront();
        }
    }
}
