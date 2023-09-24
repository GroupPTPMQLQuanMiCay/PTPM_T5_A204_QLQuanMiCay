using System;
using System.Windows.Forms;
using DataHelper;
using DataHelper.DTO.NguyenLieu;
using FormControl.Repository;
using FormControl.Service;

namespace FormControl
{
    public partial class UFNguyenLieu : UserControl
    {
        private SqlHelper sqlHelper;
        private NguyenLieuRepository _repository;
        private NguyenLieuService _service;
        public UFNguyenLieu(string connectionString)
        {
            InitializeComponent();
            sqlHelper = new SqlHelper(connectionString);
            _repository = new NguyenLieuRepository(sqlHelper);
            _service = new NguyenLieuService(_repository);

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


        }

        private void drvNguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = drvNguyenLieu.CurrentRow;
            if(row != null)
            {
                txtId.Text = row.Cells[0].Value.ToString();
                txtTenNL.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                cboDonViTinh.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtTimTenNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenNL = txtTimTenNL.Text.Trim();
            if ("".Equals(tenNL))
            {
                drvNguyenLieu.DataSource = _service.getAll().DefaultView;
            } else
            {
                drvNguyenLieu.DataSource = _service.getNguyenLieuDtoByName(tenNL).DefaultView;
            }
        }
    }
}
