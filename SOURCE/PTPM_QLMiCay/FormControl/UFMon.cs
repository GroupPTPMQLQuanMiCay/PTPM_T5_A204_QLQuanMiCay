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
    public partial class UFMon : UserControl
    {
        DAL_Mon monDal = new DAL_Mon();
        DAL_NguyenLieu nlDal = new DAL_NguyenLieu();
        DAL_DanhMuc dmDal = new DAL_DanhMuc();
        List<Mon_Co_NL> listNLieu = new List<Mon_Co_NL>();

        public UFMon()
        {
            InitializeComponent();
        }

        private void UFMon_Load(object sender, EventArgs e)
        {
            drvMon.DataSource = monDal.loadData();
            drvNL.DataSource = nlDal.getIncredientTableMon();
            cboDanhMuc.DataSource = dmDal.loadData();
            cboDanhMuc.DisplayMember = "DM_Ten";
            cboDanhMuc.ValueMember = "DM_Id";
            drvNLieu.Rows.Clear();
        }

        private void drvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string tenMon = drvMon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMon.Text = tenMon;
                Mon m = monDal.GetMon(tenMon);
                cboDanhMuc.SelectedItem = m.DanhMuc.DM_Ten;
                txtDonGia.Text = m.M_Gia.ToString();
                cboDanhMuc.SelectedIndex = cboDanhMuc.FindStringExact(m.DanhMuc.DM_Ten);
                picMon.Image = Image.FromFile(@"..\..\..\CustomControl\Images\" + m.M_IMG);
                picMon.SizeMode = PictureBoxSizeMode.StretchImage;
                capNhatListNLieu(m.M_Ten);
            }
        }

        public void capNhatListNLieu(string tenMon)
        {
            drvNLieu.Rows.Clear();
            drvNLieu.Refresh();
            listNLieu = nlDal.getIncredientByMon(tenMon);
            for(int i = 0; i< listNLieu.Count; i++)
            {
                NguyenLieu nl = listNLieu[i].NguyenLieu;
                if (drvNLieu.Rows[0].Cells[0].Value == null)
                {
                    drvNLieu.Rows[0].Cells[0].Value = nl.NL_Id;
                    drvNLieu.Rows[0].Cells[1].Value = nl.NL_Ten;
                    drvNLieu.Rows[0].Cells[2].Value = nl.NL_DonViTinh;
                    drvNLieu.Rows[0].Cells[3].Value = listNLieu[i].MNL_SoLuong;
                }
                else
                {
                    int rowIndex = drvNLieu.Rows.Add();
                    drvNLieu.Rows[rowIndex].Cells[0].Value = nl.NL_Id;
                    drvNLieu.Rows[rowIndex].Cells[1].Value = nl.NL_Ten;
                    drvNLieu.Rows[rowIndex].Cells[2].Value = nl.NL_DonViTinh;
                    drvNLieu.Rows[rowIndex].Cells[3].Value = listNLieu[i].MNL_SoLuong;
                }
            }
        }

        public void capNhatListSauKhiThem()
        {
            drvNLieu.Rows.Clear();
            drvNLieu.Refresh();
            for (int i = 0; i < listNLieu.Count; i++)
            {
                NguyenLieu nl = listNLieu[i].NguyenLieu;
                if(nl == null)
                {
                    nl = new NguyenLieu();
                    nl.NL_Id = listNLieu[i].NL_Id;
                    NguyenLieu nlieu = nlDal.getIncredientById(nl.NL_Id);
                    nl.NL_Ten = nlieu.NL_Ten;
                    nl.NL_DonViTinh = nlieu.NL_DonViTinh;
                }

                if (drvNLieu.Rows[0].Cells[0].Value == null)
                {
                    drvNLieu.Rows[0].Cells[0].Value = nl.NL_Id;
                    drvNLieu.Rows[0].Cells[1].Value = nl.NL_Ten;
                    drvNLieu.Rows[0].Cells[2].Value = nl.NL_DonViTinh;
                    drvNLieu.Rows[0].Cells[3].Value = listNLieu[i].MNL_SoLuong;
                }
                else
                {
                    int rowIndex = drvNLieu.Rows.Add();
                    drvNLieu.Rows[rowIndex].Cells[0].Value = nl.NL_Id;
                    drvNLieu.Rows[rowIndex].Cells[1].Value = nl.NL_Ten;
                    drvNLieu.Rows[rowIndex].Cells[2].Value = nl.NL_DonViTinh;
                    drvNLieu.Rows[rowIndex].Cells[3].Value = listNLieu[i].MNL_SoLuong;
                }
            }
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void cGroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text;
            string donGia = txtDonGia.Text;
            string danhMuc = cboDanhMuc.SelectedValue.ToString();

            try
            {
                if (monDal.insert(tenMon, danhMuc, donGia))
                {
                    MessageBox.Show("Thêm món thành công");
                    drvMon.DataSource = monDal.loadData();
                }
            }
            catch
            {
                Message.Message.showFailedDBExecution("thêm món", "món");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            drvNLieu.Rows.Clear();
            listNLieu.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa món này?", "Thông báo", MessageBoxButtons.YesNo);
            try
            {
                if (rs == DialogResult.Yes)
                {
                    string tenMon = txtTenMon.Text;
                    monDal.delete(tenMon);
                    drvMon.DataSource = monDal.loadData();
                    MessageBox.Show("Xóa món thành công");
                }
            }
            catch
            {
                MessageBox.Show("Xóa món thất bại");
            }
        }

        private void drvNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                string id = drvNL.Rows[e.RowIndex].Cells[2].Value.ToString();
                Mon_Co_NL mon = new Mon_Co_NL();
                NguyenLieu nl = nlDal.getIncredientByName(id);
                mon.NL_Id = nl.NL_Id;
                mon.MNL_SoLuong = 1;
                listNLieu.Add(mon);
                capNhatListSauKhiThem();
            }
        }

        private void drvNLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                NguyenLieu nl = listNLieu[e.RowIndex].NguyenLieu;
                if(nl == null)
                {
                    listNLieu.RemoveAt(e.RowIndex);
                    capNhatListSauKhiThem();
                } else
                {
                    string tenMon = txtTenMon.Text;
                    monDal.deleteNguyenLieuMon(tenMon, nl.NL_Id);
                    listNLieu.RemoveAt(e.RowIndex);
                    capNhatListSauKhiThem();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text;
            string donGia = txtDonGia.Text;
            string danhMuc = cboDanhMuc.SelectedValue.ToString();

            try
            {
                if (monDal.update(tenMon, danhMuc, donGia))
                {
                    for(int i = 0; i < listNLieu.Count; i++)
                    {
                        monDal.updateNguyenLieuMon(tenMon, listNLieu[i].NL_Id, listNLieu[i].MNL_SoLuong.ToString());
                    }
                    MessageBox.Show("Cập nhật nguyên liệu món thành công");
                    drvMon.DataSource = monDal.loadData();
                }
            }
            catch
            {
                Message.Message.showFailedDBExecution("thêm món", "món");
            }
        }
    }
}
