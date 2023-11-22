using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace FormControl.Forms
{
    public partial class frmHoaDonNhap : Form
    {
        TaiKhoan _user = null;
        DAL_NhaCungCap nccDal = new DAL_NhaCungCap();
        DAL_ChiTietNhap ctDal = new DAL_ChiTietNhap();
        DAL_HoaDonNhap hdDal = new DAL_HoaDonNhap();
        List<ChiTietNhap> listCTNhap = new List<ChiTietNhap>();
        DAL_NguyenLieu nlDal = new DAL_NguyenLieu();
        DAL_PhieuDat pdDal = new DAL_PhieuDat();
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        public frmHoaDonNhap(TaiKhoan user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            try
            {
                List<NhaCungCap> lstNcc = nccDal.getAllSupplierFull();
                cboNhaCungCap.DataSource = lstNcc;
                cboNhaCungCap.DisplayMember ="NCC_Ten";
                cboNhaCungCap.ValueMember = "NCC_Id";

                List<PhieuDat> listPhieuDat = pdDal.getIncredientOrdersHadSent();
                cboMaDH.DataSource = listPhieuDat;
                cboMaDH.DisplayMember = "PD_Id";
                cboMaDH.ValueMember = "PD_Id";
            } catch
            {

            }
        }

        private void cGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaDH.Text = "";
            int maNcc = ((NhaCungCap)cboNhaCungCap.SelectedItem).NCC_Id;
            drvHDN.DataSource = hdDal.getListOrderReceiptBySupplier(maNcc);
            if(drvHDN.Rows.Count == 0)
            {
                drvNLNhap.Rows.Clear();
            }
        }

        private void drvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int hdnId = int.Parse(drvHDN.Rows[e.RowIndex].Cells[0].Value.ToString());
                listCTNhap = ctDal.getIncredientDetail(hdnId);
                drvNLNhap.Rows.Clear();
                for (int i = 0; i < listCTNhap.Count; i++)
                {
                    int index = drvNLNhap.Rows.Add();
                    NguyenLieu nl = nlDal.getIncredientById(listCTNhap[i].NL_Id);
                    drvNLNhap.Rows[index].Cells[0].Value = listCTNhap[i].NL_Id;
                    drvNLNhap.Rows[index].Cells[1].Value = nl.NL_Ten;
                    drvNLNhap.Rows[index].Cells[2].Value = nl.NL_DonViTinh;
                    drvNLNhap.Rows[index].Cells[3].Value = listCTNhap[i].CTN_SoLuong;
                    drvNLNhap.Rows[index].Cells[4].Value = listCTNhap[i].CTN_Gia;
                    drvNLNhap.Rows[index].Cells[5].Value = listCTNhap[i].CTN_SoLuong * listCTNhap[i].CTN_Gia;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dateNgayNhap.Value;
            drvHDN.DataSource = hdDal.getListOrderReceiptByDate(ngayNhap);
            if (drvHDN.Rows.Count == 0)
            {
                drvNLNhap.Rows.Clear();
            }
        }

        private void cboMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNhaCungCap.Text = "";
            int maPd = ((PhieuDat)cboMaDH.SelectedItem).PD_Id;
            drvHDN.DataSource = hdDal.getListOrderReceiptByOrder(maPd);
            if (drvHDN.Rows.Count == 0)
            {
                drvNLNhap.Rows.Clear();
            }
        }
    }
}
