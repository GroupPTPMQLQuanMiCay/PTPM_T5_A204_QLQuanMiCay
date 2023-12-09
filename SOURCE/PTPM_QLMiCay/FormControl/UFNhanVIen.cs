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

namespace FormControl
{
    public partial class UFNhanVIen : UserControl
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public UFNhanVIen()
        {
            InitializeComponent();
        }

        private void cLable2_Click(object sender, EventArgs e)
        {

        }

        private void cLable6_Click(object sender, EventArgs e)
        {

        }

        private void cButton3_Click(object sender, EventArgs e)
        {

        }

        private void UFNhanVIen_Load(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.DataSource = dalNhanVien.getAllNV();
            }
            catch
            {
                Message.Message.showErrorLoadData("nhà cung cấp");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                txtID.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTinhTrang.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
