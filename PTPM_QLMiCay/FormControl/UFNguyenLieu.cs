using DataHelper;
using FormControl.Repository;
using FormControl.Service;
using System;
using System.Data;
using System.Windows.Forms;
using FormControl.Message;

namespace FormControl
{
    public partial class UFNguyenLieu : UserControl
    {
        private SqlHelper sqlHelper;
        private NguyenLieuRepository _repository;
        private NguyenLieuService _service;

        private NhaCungCapRepository _nccRepository;
        private NhaCungCapService _nccService;
        public UFNguyenLieu(string connectionString)
        {
            InitializeComponent();
            sqlHelper = new SqlHelper(connectionString);
            _repository = new NguyenLieuRepository(sqlHelper);
            _service = new NguyenLieuService(_repository);
            _nccRepository = new NhaCungCapRepository(sqlHelper);
            _nccService = new NhaCungCapService(_nccRepository);

            drvNguyenLieu.DataSource = _service.getAll().DefaultView;
        }

        private void cGroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UFNguyenLieu_Load(object sender, EventArgs e)
        {
            if(sqlHelper == null)
            {
                MessageBox.Show("Error occurs when connect to database");
                return;
            }

            DataTable dtNcc = _nccService.getAll();
            if (dtNcc != null)
            {
                DataRow dr = dtNcc.NewRow();
                dr["NCC_Ten"] = "Tất cả";
                dr["NCC_Id"] = 0;
                dtNcc.Rows.Add(dr);
                cboNhaCungCap.DataSource = dtNcc;
                cboNhaCungCap.DisplayMember = "NCC_Ten";
                cboNhaCungCap.ValueMember = "NCC_Id";
                cboNhaCungCap.SelectedValue = 0;
            }
        }

        private void txtTimTenNL_OnValueChanged(object sender, EventArgs e)
        {
            string tenNL = txtTimTenNL.Text.Trim();

            try
            {
                if (int.Parse(cboNhaCungCap.SelectedValue.ToString()) == 0)
                {
                    if ("".Equals(tenNL))
                    {
                        drvNguyenLieu.DataSource = _service.getAll().DefaultView;
                    }
                    else
                    {
                        drvNguyenLieu.DataSource = _service.getNguyenLieuDtoByName(tenNL).DefaultView;
                    }
                }
                else
                {
                    int nccId = int.Parse(cboNhaCungCap.SelectedValue.ToString());
                    if ("".Equals(tenNL))
                    {
                        drvNguyenLieu.DataSource = _service.getNguyenLieuDtoByNhaCungCap(nccId).DefaultView;
                    }
                    else
                    {
                        drvNguyenLieu.DataSource = _service.getNguyenLieuDtoByNhaCungCapAndName(nccId, tenNL).DefaultView;
                    }
                }
            }
            catch
            {

            }
        }

        private void cboNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cboNhaCungCap.SelectedValue.ToString()) == 0)
                {
                    drvNguyenLieu.DataSource = _service.getAll().DefaultView;
                }
                else
                {
                    int nccId = int.Parse(cboNhaCungCap.SelectedValue.ToString());
                    drvNguyenLieu.DataSource = _service.getNguyenLieuDtoByNhaCungCap(nccId).DefaultView;
                }
            }
            catch
            {
                return;
            }
        }

        private void drvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = drvNguyenLieu.CurrentRow;
            if (row != null)
            {
                txtId.Text = row.Cells[0].Value.ToString();
                txtTenNL.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                cboDonViTinh.SelectedText = row.Cells[2].Value.ToString();
            }
        }
    }
}
