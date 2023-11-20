using BLL_DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormControl.Forms
{
    public partial class frmDatNguyenLieu : Form
    {
        TaiKhoan _user = null;
        DAL_NhaCungCap nccDal = new DAL_NhaCungCap();
        DAL_NguyenLieu nlDal  = new DAL_NguyenLieu();
        DAL_GiaNguyenLieu giaDal = new DAL_GiaNguyenLieu();
        DAL_CTPhieuDat ctDal = new DAL_CTPhieuDat();
        DAL_PhieuDat pdDal = new DAL_PhieuDat();
        List<CTPhieuDat> listCTPD = new List<CTPhieuDat>();

        private static int INVALID_PARAMETER = -1;
        private static int ERROR_ON_EXECUTION = -2;
        private static int SUCCESS = 1;

        public frmDatNguyenLieu()
        {
            InitializeComponent();
        }

        public frmDatNguyenLieu(TaiKhoan user)
        {
            InitializeComponent();
            _user = user;
            txtNhanVien.Text = _user.NhanVien.NV_Ten;
        }

        private void frmDatNguyenLieu_Load(object sender, EventArgs e)
        {
            List<NhaCungCap> listNhaCungCap = nccDal.getAllSupplierFull();
            cbb_NCC.DataSource = listNhaCungCap;
            cbb_NCC.DisplayMember = "NCC_Ten";
            cbb_NCC.ValueMember = "NCC_Id";

            loadIncredientTable();
        }

        public void loadIncredientTable()
        {
            drvNguyenLieu.DataSource = giaDal.getIncredientWithPrice(int.Parse(cbb_NCC.SelectedValue.ToString()));
        }

        private void cbb_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nccId = int.Parse(cbb_NCC.SelectedValue.ToString());
                if (nccId == 0)
                {
                    loadIncredientTable();
                }
                else
                {
                    drvNguyenLieu.DataSource = nlDal.getIncredientBySupplier(nccId);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnThemVaoPD_Click(object sender, EventArgs e)
        {
            if (drvNguyenLieu.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = drvNguyenLieu.CurrentRow;
                try
                {
                    int sl = int.Parse(txtSL.Text);
                    if(sl >= 0)
                    {
                        CTPhieuDat ctpd = new CTPhieuDat();
                        ctpd.NL_Id = int.Parse(row.Cells[0].Value.ToString());
                        ctpd.NL_Gia = double.Parse(row.Cells[3].Value.ToString());
                        ctpd.soluong = sl;
                        ctpd.DaGiao = 0;

                        listCTPD.Add(ctpd);
                    } 
                    else
                    {
                        Message.Message.showInvalidParameterMessage("số lượng");
                    }
                } catch
                {
                    Message.Message.showMissingInfoMessage("số lượng", "thêm nguyên liệu vào phiếu đặt");
                }
            }
            updateTableDatIncredient();
        }

        public void updateTableDatIncredient()
        {
            double sum = 0;
            drvNLDat.Rows.Clear();
            for(int i = 0; i < listCTPD.Count; i++)
            {
                int index = drvNLDat.Rows.Add();
                NguyenLieu nl = nlDal.getIncredientById(listCTPD[i].NL_Id);
                drvNLDat.Rows[index].Cells[0].Value = listCTPD[i].NL_Id;
                drvNLDat.Rows[index].Cells[1].Value = nl.NL_Ten;
                drvNLDat.Rows[index].Cells[2].Value = nl.NL_DonViTinh;
                drvNLDat.Rows[index].Cells[3].Value = listCTPD[i].soluong;
                drvNLDat.Rows[index].Cells[4].Value = listCTPD[i].NL_Gia;
                drvNLDat.Rows[index].Cells[5].Value = listCTPD[i].soluong * listCTPD[i].NL_Gia;
                sum += listCTPD[i].soluong * listCTPD[i].NL_Gia;
            }
            if(drvNLDat.Columns.Count == 6)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Xóa";
                btn.UseColumnTextForButtonValue = true;
                drvNLDat.Columns.Add(btn);
            }
        
            txtThanhTien.Text = sum.ToString();
        }

        private void drvNLDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                listCTPD.RemoveAt(e.RowIndex);
                updateTableDatIncredient();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = drvNLDat.CurrentRow.Index;
            if (row >= 0)
            {
                CTPhieuDat ctpd = listCTPD[row];
                try
                {
                    int sl = int.Parse(txtSL.Text);
                    ctpd.soluong = sl;
                    listCTPD.RemoveAt(row);
                    listCTPD.Insert(row, ctpd);
                    updateTableDatIncredient();
                } catch
                {
                    Message.Message.showInvalidParameterMessage("số lượng");
                }
            }
        }

        private void btnLapPD_Click(object sender, EventArgs e)
        {
            try
            {
                int result = pdDal.insert(_user.TK_NhanVien, dateNgayNhap.Value);
                switch (result) {
                    case 1:
                        {
                            PhieuDat pd = pdDal.getLatestIncredientOrder();
                            if(pd != null)
                            {
                                handleInsertIncredientOrderDetail(pd.PD_Id);
                            }
                            break;
                        }
                    case -2:
                        Message.Message.showCreateFailed("phiếu đặt");
                        break;
                }
            } catch
            {
                Message.Message.showCreateFailed("phiếu đặt");
            }
        }

        public void handleInsertIncredientOrderDetail(int pdId)
        {
            int rs = SUCCESS;
            try
            {
                for(int i = 0; i < listCTPD.Count; i++)
                {
                    CTPhieuDat dt = listCTPD[i];
                    int result = ctDal.insert(pdId, dt.NL_Id, dt.soluong, dt.NL_Gia);
                    switch (result)
                    {
                        case 1:
                            break;
                        case -2:
                            Message.Message.showCreateFailed("phiếu đặt");
                            rs = ERROR_ON_EXECUTION;
                            break;
                    }
                }
            }
            catch
            {
                Message.Message.showCreateFailed("chi tiết phiếu đặt");
            }

            switch (rs)
            {
                case 1:
                    {
                        Message.Message.showCreateSuccessfully("phiếu đặt");
                        break;
                    }
                case -2:
                    Message.Message.showCreateFailed("phiếu đặt");
                    break;
            }
        }
    }
}
