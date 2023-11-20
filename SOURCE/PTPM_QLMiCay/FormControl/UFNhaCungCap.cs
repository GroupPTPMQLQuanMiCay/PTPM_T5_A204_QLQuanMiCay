using System;
using System.Windows.Forms;
using BLL_DAL;

namespace FormControl
{
    public partial class UFNhaCungCap : UserControl
    {
        DAL_NhaCungCap nccDal = new DAL_NhaCungCap();
        bool isAdd = false;
        TaiKhoan _user = null;
        public UFNhaCungCap()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtID.Enabled = false;
        }

        public UFNhaCungCap(TaiKhoan user)
        {
            InitializeComponent();
            _user = user;
            btnLuu.Enabled = false;
            txtID.Enabled = false;
        }

        private void cTextBox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void UFNhaCungCap_Load(object sender, EventArgs e)
        {
            try
            {
                drvNhaCungCap.DataSource = nccDal.getAllSupplier();
            } catch
            {
                Message.Message.showErrorLoadData("nhà cung cấp");
            }
        }

        private void drvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = drvNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDiaChi.Text = drvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNhaCungCap.Text = drvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = drvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            try
            {
                if ("".Equals(search))
                {
                    drvNhaCungCap.DataSource = nccDal.getAllSupplier();
                }
                else
                {
                    drvNhaCungCap.DataSource = nccDal.getSupplierByName(search);
                }
            }
            catch
            {

            }
        }

        public void reset()
        {
            txtID.Text = txtDiaChi.Text = txtNhaCungCap.Text = txtSDT.Text = "";
            txtID.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            isAdd = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string tenNcc = txtNhaCungCap.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            if (isAdd)
            {
                handleWhenAddSupplier(tenNcc, diaChi, sdt);
            } else
            {
                handleWhenUpdateSupplier(id, tenNcc, diaChi, sdt);
            }
        }

        public void handleWhenAddSupplier(string ten, string diaChi, string sdt)
        {
            int result = nccDal.add(_user.TK_NhanVien, ten, diaChi, sdt);
            switch (result)
            {
                case 1:
                    Message.Message.showCreateSuccessfully("nhà cung cấp");
                    isAdd = false;
                    btnLuu.Enabled = false;
                    drvNhaCungCap.DataSource = nccDal.getAllSupplier();
                    break;
                case -1:
                    Message.Message.showMissingInfoMessage("", "thêm nhà cung cấp");
                    break;
                case -2:
                    Message.Message.showCreateFailed("nhà cung cấp");
                    break;
            }
        }

        public void handleWhenUpdateSupplier(string id, string ten, string diaChi, string sdt)
        {
            int result = nccDal.update(_user.TK_NhanVien, id, ten, diaChi, sdt);
            switch (result)
            {
                case 1:
                    Message.Message.showUpdateSuccessfully("nhà cung cấp");
                    isAdd = false;
                    btnLuu.Enabled = false;
                    drvNhaCungCap.DataSource = nccDal.getAllSupplier();
                    break;
                case -1:
                    Message.Message.showMissingInfoMessage("", "cập nhật nhà cung cấp");
                    break;
                case -2:
                    Message.Message.showUpdateFailed("nhà cung cấp");
                    break;
            }
        }

        public void handleWhenDeleteSupplier(string id)
        {
            int result = nccDal.delete(_user.TK_NhanVien, id);
            switch (result)
            {
                case 1:
                    Message.Message.showDeleteSuccessfully("nhà cung cấp");
                    drvNhaCungCap.DataSource = nccDal.getAllSupplier();
                    break;
                case -1:
                    Message.Message.showMissingInfoMessage("", "xóa nhà cung cấp");
                    break;
                case -2:
                    Message.Message.showDeleteFailed("nhà cung cấp");
                    break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                string id = txtID.Text;
                handleWhenDeleteSupplier(id);
            }
        }
    }
}
