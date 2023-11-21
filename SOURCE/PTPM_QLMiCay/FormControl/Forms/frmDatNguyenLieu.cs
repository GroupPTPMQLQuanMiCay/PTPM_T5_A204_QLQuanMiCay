using BLL_DAL;
using CustomControl.ControlCustom;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormControl.Forms
{
    public partial class frmDatNguyenLieu : Form
    {
        TaiKhoan _user = null;
        DAL_NhaCungCap nccDal = new DAL_NhaCungCap();
        DAL_NguyenLieu nlDal = new DAL_NguyenLieu();
        DAL_GiaNguyenLieu giaDal = new DAL_GiaNguyenLieu();
        DAL_CTPhieuDat ctDal = new DAL_CTPhieuDat();
        DAL_PhieuDat pdDal = new DAL_PhieuDat();
        List<CTPhieuDat> listCTPD = new List<CTPhieuDat>();
        PhieuDat phieuDat = null;

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


            List<PhieuDat> listPD = pdDal.getIncredientOrders();
            cboMaPD.DataSource = listPD;
            cboMaPD.DisplayMember = "PD_Id";
            cboMaPD.ValueMember = "PD_Id";
            cboMaPD.SelectedIndex = 0;
            phieuDat = pdDal.getIncredientOrder(int.Parse(cboMaPD.SelectedValue.ToString()));
            loadIncredientTable();
            loadIncredientOrderDetail();
        }

        public void loadIncredientTable()
        {
            drvNguyenLieu.DataSource = giaDal.getIncredientWithPrice(int.Parse(cbb_NCC.SelectedValue.ToString()));
        }

        public void loadIncredientOrderDetail()
        {
            int pdID = ((PhieuDat)cboMaPD.SelectedItem).PD_Id;
            listCTPD = ctDal.getIncredientOrderDetail(pdID);
            if (listCTPD.Count == 0)
            {
                return;
            }
            drvNguyenLieu.DataSource = giaDal.getIncredientWithPrice(int.Parse(cbb_NCC.SelectedValue.ToString()));

            double sum = 0;
            drvNLDat.Rows.Clear();
            for (int i = 0; i < listCTPD.Count; i++)
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
            if (drvNLDat.Columns.Count == 6)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Text = "Xóa";
                btn.UseColumnTextForButtonValue = true;
                drvNLDat.Columns.Add(btn);
            }

            txtThanhTien.Text = sum.ToString();
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
                    drvNguyenLieu.DataSource = giaDal.getIncredientWithPrice(nccId);
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
                if (listCTPD.Count > 0)
                {
                    NguyenLieu nl = nlDal.getIncredientById(int.Parse(row.Cells[0].Value.ToString()));
                    NguyenLieu nlDaDat = nlDal.getIncredientById(listCTPD[0].NL_Id);
                    if (nl.NCC_Id != nlDaDat.NCC_Id)
                    {
                        MessageBox.Show("Đơn đặt hàng chỉ đặt những mặt hàng của 1 nhà cung cấp");
                        return;
                    }
                }

                try
                {
                    int sl = int.Parse(txtSL.Text);
                    for (int i = 0; i < listCTPD.Count; i++)
                    {
                        if (listCTPD[i].NL_Id == int.Parse(row.Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("Nguyên liệu đã có trong đơn đặt nguyên liệu");
                            return;
                        }
                    }

                    if (sl >= 0)
                    {
                        if (phieuDat == null)
                        {
                            CTPhieuDat ctpd = new CTPhieuDat();
                            ctpd.NL_Id = int.Parse(row.Cells[0].Value.ToString());
                            ctpd.NL_Gia = double.Parse(row.Cells[4].Value.ToString());
                            ctpd.soluong = sl;
                            ctpd.DaGiao = 0;

                            listCTPD.Add(ctpd);
                        }
                        else
                        {
                            if (phieuDat.isSentSupplier)
                            {
                                Message.Message.showUpdateFailedAfterSend("phiếu đặt", "đã đặt nguyên liệu");
                                return;
                            }

                            int pdId = phieuDat.PD_Id;
                            int nlId = int.Parse(row.Cells[0].Value.ToString());
                            double gia = double.Parse(row.Cells[4].Value.ToString());
                            ctDal.insert(pdId, nlId, sl, gia);
                            pdDal.update(pdId, _user.TK_NhanVien, dateNgayNhap.Value);
                        }
                    }
                    else
                    {
                        Message.Message.showInvalidParameterMessage("số lượng");
                    }
                    updateTableDatIncredient();
                }
                catch
                {
                    Message.Message.showMissingInfoMessage("số lượng", "thêm nguyên liệu vào phiếu đặt");
                }
            }
        }

        public void updateTableDatIncredient()
        {
            double sum = 0;
            drvNLDat.Rows.Clear();
            if (phieuDat != null)
            {
                listCTPD = ctDal.getIncredientOrderDetail(phieuDat.PD_Id);
            }

            for (int i = 0; i < listCTPD.Count; i++)
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
            if (drvNLDat.Columns.Count == 6)
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
            if (e.RowIndex >= listCTPD.Count)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                if (phieuDat == null)
                {
                    listCTPD.RemoveAt(e.RowIndex);
                }
                else
                {
                    if (phieuDat.isSentSupplier)
                    {
                        Message.Message.showUpdateFailedAfterSend("phiếu đặt", "đã đặt nguyên liệu");
                        return;
                    }

                    DataGridViewRow row = drvNLDat.CurrentRow;
                    int pdId = phieuDat.PD_Id;
                    int nlId = int.Parse(row.Cells[0].Value.ToString());
                    ctDal.delete(pdId, nlId);
                    pdDal.update(pdId, _user.TK_NhanVien, dateNgayNhap.Value);
                }
                updateTableDatIncredient();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = drvNLDat.CurrentRow;
            if (row.Index >= 0)
            {
                CTPhieuDat ctpd = listCTPD[row.Index];

                try
                {
                    int sl = int.Parse(txtSL.Text);
                    if (phieuDat == null)
                    {
                        ctpd.soluong = sl;
                        listCTPD.RemoveAt(row.Index);
                        listCTPD.Insert(row.Index, ctpd);
                    }
                    else
                    {
                        if (phieuDat.isSentSupplier)
                        {
                            Message.Message.showUpdateFailedAfterSend("phiếu đặt", "đã đặt nguyên liệu");
                            return;
                        }

                        int pdId = phieuDat.PD_Id;
                        int nlId = int.Parse(row.Cells[0].Value.ToString());
                        double gia = double.Parse(row.Cells[4].Value.ToString());
                        ctDal.update(pdId, nlId, sl, gia);
                        pdDal.update(pdId, _user.TK_NhanVien, dateNgayNhap.Value);
                    }
                    updateTableDatIncredient();
                }
                catch
                {
                    Message.Message.showInvalidParameterMessage("số lượng");
                }
            }
        }

        private void btnLapPD_Click(object sender, EventArgs e)
        {
            try
            {
                if (phieuDat == null)
                {
                    int result = pdDal.insert(_user.TK_NhanVien, dateNgayNhap.Value);
                    switch (result)
                    {
                        case 1:
                            {
                                phieuDat = pdDal.getLatestIncredientOrder();
                                if (phieuDat != null)
                                {
                                    handleInsertIncredientOrderDetail(phieuDat.PD_Id);
                                }
                                List<PhieuDat> listPD = pdDal.getIncredientOrders();
                                cboMaPD.DataSource = listPD;
                                cboMaPD.DisplayMember = "PD_Id";
                                cboMaPD.ValueMember = "PD_Id";
                                cboMaPD.SelectedIndex = 0;
                                break;
                            }
                        case -2:
                            Message.Message.showCreateFailed("phiếu đặt");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Thất bại do phiếu đã lập trước đó");
                }

            }
            catch
            {
                Message.Message.showCreateFailed("phiếu đặt");
            }
        }

        public void handleInsertIncredientOrderDetail(int pdId)
        {
            int rs = SUCCESS;
            try
            {
                for (int i = 0; i < listCTPD.Count; i++)
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
                        Message.Message.showCreateSuccessfully("phiếu đặt có mã phiếu đặt " + pdId);
                        break;
                    }
                case -2:
                    Message.Message.showCreateFailed("phiếu đặt");
                    break;
            }
        }

        public void initForm()
        {
            phieuDat = null;
            listCTPD.Clear();
            double sum = 0;
            drvNLDat.Rows.Clear();
            txtThanhTien.Text = sum.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            initForm();
        }

        private void btnDatNL_Click(object sender, EventArgs e)
        {
            if (phieuDat.isSentSupplier)
            {
                Message.Message.showUpdateFailedAfterSend("phiếu đặt", "đã đặt nguyên liệu");
                return;
            }

            DialogResult rs = MessageBox.Show("Chọn đặt hàng sẽ không thể sửa lại thông tin, bạn chắc chắn chứ?",
                                              "Thông báo",
                                              MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    int result = pdDal.sendToSupplier(phieuDat.PD_Id, _user.TK_NhanVien);
                    switch (result)
                    {
                        case -2:
                            Message.Message.showFailedDBExecution("nhập nguyên liệu", "phiếu lập");
                            break;
                        case -1:
                            Message.Message.showInvalidParameterMessage("");
                            break;
                        case 1:
                            Message.Message.showCreateSuccessfully("nhập nguyên liệu");
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể gửi yêu cầu nhập nguyên liệu");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (phieuDat != null)
            {
                if (phieuDat.isSentSupplier)
                {
                    Message.Message.showUpdateFailedAfterSend("phiếu đặt", "đã đặt nguyên liệu");
                    return;
                }

                for (int i = 0; i < listCTPD.Count; i++)
                {
                    ctDal.delete(phieuDat.PD_Id, listCTPD[i].NL_Id);
                }
                pdDal.delete(phieuDat.PD_Id, _user.TK_NhanVien);
            }
            List<PhieuDat> listPD = pdDal.getIncredientOrders();
            cboMaPD.DataSource = listPD;
            cboMaPD.DisplayMember = "PD_Id";
            cboMaPD.ValueMember = "PD_Id";
            cboMaPD.SelectedIndex = 0;
            initForm();
        }

        private void cboMaPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadIncredientOrderDetail();
            phieuDat = pdDal.getIncredientOrder(((PhieuDat)cboMaPD.SelectedItem).PD_Id);
        }
    }
}
