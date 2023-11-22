using BLL_DAL;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace FormControl.Forms
{
    public partial class frmNhapNguyenLieu : Form
    {
        TaiKhoan _user = null;
        DAL_PhieuDat pdDal = new DAL_PhieuDat();
        List<CTPhieuDat> listCTPD = new List<CTPhieuDat>();
        DAL_CTPhieuDat ctDal = new DAL_CTPhieuDat();
        DAL_NguyenLieu nlDal = new DAL_NguyenLieu();
        DAL_HoaDonNhap hdNhapDal = new DAL_HoaDonNhap();
        DAL_ChiTietNhap ctNhapDal = new DAL_ChiTietNhap();
        HoaDonNhap hd = null;

        public frmNhapNguyenLieu()
        {
            InitializeComponent();
        }

        public frmNhapNguyenLieu(TaiKhoan user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = _user.NhanVien.NV_Ten;
            List<PhieuDat> listPhieuDat = pdDal.getIncredientOrdersHadSent();
            cboMaDH.DataSource = listPhieuDat;
            cboMaDH.DisplayMember = "PD_Id";
            cboMaDH.ValueMember = "PD_Id";

            listCTPD = ctDal.getIncredientOrderDetail(((PhieuDat)cboMaDH.SelectedItem).PD_Id);
            loadIncredientOrderDetail();
            txtNhaCC.Enabled = false;
            txtNhaCC.Text = listCTPD[0].NguyenLieu.NhaCungCap.NCC_Ten;
        }

        public void loadIncredientOrderDetail()
        {
            int pdID = ((PhieuDat)cboMaDH.SelectedItem).PD_Id;
            listCTPD = ctDal.getIncredientOrderDetail(pdID);
            if (listCTPD.Count == 0)
            {
                return;
            }
            
            double sum = 0;
            drvNLNhap.Rows.Clear();
            for (int i = 0; i < listCTPD.Count; i++)
            {
                if (listCTPD[i].soluong == listCTPD[i].DaGiao)
                {
                    continue;
                }

                int index = drvNLNhap.Rows.Add();
                NguyenLieu nl = nlDal.getIncredientById(listCTPD[i].NL_Id);
                drvNLNhap.Rows[index].Cells[0].Value = listCTPD[i].NL_Id;
                drvNLNhap.Rows[index].Cells[1].Value = nl.NL_Ten;
                drvNLNhap.Rows[index].Cells[2].Value = nl.NL_DonViTinh;
                drvNLNhap.Rows[index].Cells[3].Value = listCTPD[i].soluong - listCTPD[i].DaGiao;
                drvNLNhap.Rows[index].Cells[4].Value = listCTPD[i].soluong - listCTPD[i].DaGiao;
                drvNLNhap.Rows[index].Cells[5].Value = listCTPD[i].NL_Gia;
                drvNLNhap.Rows[index].Cells[6].Value = (listCTPD[i].soluong - listCTPD[i].DaGiao) * listCTPD[i].NL_Gia;
                sum += (listCTPD[i].soluong - listCTPD[i].DaGiao) * listCTPD[i].NL_Gia;
            }
            if (drvNLNhap.Columns.Count == 7)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Xóa";
                btn.UseColumnTextForButtonValue = true;
                drvNLNhap.Columns.Add(btn);
            }

            txtThanhTien.Text = sum.ToString();
        }

        public void updateIncredientOrderDetail(int ind, int sl)
        {
            int pdID = ((PhieuDat)cboMaDH.SelectedItem).PD_Id;
            if (listCTPD.Count == 0)
            {
                return;
            }

            DataGridViewRow row = drvNLNhap.Rows[ind];
            row.Cells[4].Value = sl;
            row.Cells[6].Value = sl * int.Parse(row.Cells[5].Value.ToString());
            updateThanhTien();

            if (drvNLNhap.Columns.Count == 7)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Xóa";
                btn.UseColumnTextForButtonValue = true;
                drvNLNhap.Columns.Add(btn);
            }
        }

        private void cboMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadIncredientOrderDetail();
            hd = null;
        }

        private void drvNLNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= listCTPD.Count)
            {
                return;
            }

            if (e.RowIndex >= 0 && e.RowIndex < drvNLNhap.RowCount - 1)
            {
                DataGridViewRow row = drvNLNhap.CurrentRow;
                txtSL.Text = row.Cells[4].Value.ToString();

                if(e.ColumnIndex == 7)
                {
                    drvNLNhap.Rows.RemoveAt(e.RowIndex);
                    updateThanhTien();
                }
            }
        }

        public void updateThanhTien()
        {
            int sum = 0;
            for(int i = 0; i < drvNLNhap.Rows.Count - 1; i++)
            {
                sum += int.Parse(drvNLNhap.Rows[i].Cells[6].Value.ToString());
            }
            txtThanhTien.Text = sum.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = drvNLNhap.CurrentRow;

            if (row != null)
            {
                try
                {
                    int sl = int.Parse(txtSL.Text);
                    if(sl > int.Parse(row.Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("Số lượng vượt quá số lượng cần giao");
                        return;
                    } else
                    {
                        updateIncredientOrderDetail(row.Index, sl);
                    }
                }
                catch
                {

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Nhập nguyên liệu sẽ không thể chỉnh sửa lại. Bạn chắc chắn chứ?", "Thông báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                int thanhTien = int.Parse(txtThanhTien.Text);
                int pdID = ((PhieuDat)cboMaDH.SelectedItem).PD_Id;
                hdNhapDal.insert(_user.TK_NhanVien, dateNgayNhap.Value, thanhTien, pdID);
                HoaDonNhap hd = hdNhapDal.getLatestIncredientDilivery();
                for(int i = 0; i < drvNLNhap.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = drvNLNhap.Rows[i];
                    int nlId = int.Parse(row.Cells[0].Value.ToString());
                    int sl = int.Parse(row.Cells[4].Value.ToString());
                    int donGia = int.Parse(row.Cells[5].Value.ToString());
                    ctNhapDal.insert(nlId, hd.HDN_Id, sl, donGia);
                    ctDal.updateDeliveredQuantity(pdID, nlId, sl);
                }
                Message.Message.showCreateSuccessfully("hóa đơn nhập có mã " + hd.HDN_Id);
                loadIncredientOrderDetail();
            }
        }
    }
}
