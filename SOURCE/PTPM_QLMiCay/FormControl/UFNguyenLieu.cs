
using BLL_DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormControl
{
    public partial class UFNguyenLieu : UserControl
    {
        //private bool isAdd;
        private bool IsAdd;
        DAL_NhaCungCap nhaCungCap = new DAL_NhaCungCap();
        DAL_NguyenLieu nguyenLieu = new DAL_NguyenLieu();
        private TaiKhoan taiKhoan;

        public UFNguyenLieu()
        {
            InitializeComponent();
        }

        public UFNguyenLieu(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }

        private void cGroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UFNguyenLieu_Load(object sender, EventArgs e)
        {
            List<NhaCungCap> listNhaCungCap = nhaCungCap.getAllSupplier();
            NhaCungCap supAll = new NhaCungCap();
            supAll.NCC_Id = 0;
            supAll.NCC_Ten = "Tất cả";
            listNhaCungCap.Insert(0, supAll);
            cboNhaCungCap.DataSource = listNhaCungCap;
            cboNhaCungCap.DisplayMember = "NCC_Ten";
            cboNhaCungCap.ValueMember = "NCC_Id";

            loadIncredientTable();
            cboDonViTinh.DataSource = nguyenLieu.getAllDonViTinh();
            btnLuu.Enabled = txtId.Enabled = false;
        }

        public void loadIncredientTable()
        {
            drvNguyenLieu.DataSource = nguyenLieu.getAllIncredient();
        }

        private void txtTimTenNL_OnValueChanged(object sender, EventArgs e)
        {
            string tenNL = txtTimTenNL.Text.Trim();

            try
            {
                if ("".Equals(tenNL))
                {
                    drvNguyenLieu.DataSource = nguyenLieu.getAllIncredient();
                }
                else
                {
                    drvNguyenLieu.DataSource = nguyenLieu.getIncredientName(tenNL);
                }
            }
            catch
            {
                return;
            }
        }

        private void cboNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nccId = int.Parse(cboNhaCungCap.SelectedValue.ToString());
                if (nccId == 0)
                {
                    drvNguyenLieu.DataSource = nguyenLieu.getAllIncredient();
                }
                else
                {
                    drvNguyenLieu.DataSource = nguyenLieu.getIncredientBySupplier(nccId);
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
                cboDonViTinh.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            IsAdd = btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                if (checkUserInputForAdding())
                {
                    try
                    {
                        if (nguyenLieu.insert(txtTenNL.Text, cboDonViTinh.Text, txtDonGia.Text, cboNhaCungCap.SelectedValue.ToString(), taiKhoan.TK_NhanVien))
                        {
                            MessageBox.Show("Thêm nguyên liệu thành công");
                            loadIncredientTable();
                        }
                    }
                    catch
                    {
                        Message.Message.showFailedDBExecution("thêm nguyên liệu", "nguyên liệu");
                    } finally
                    {
                        btnLuu.Enabled = IsAdd = false;
                    }
                } 
            }
            else
            {
                if (checkUserInputForAdjusting())
                {
                    try
                    {
                        if (nguyenLieu.update(txtId.Text ,txtTenNL.Text, cboDonViTinh.Text, txtDonGia.Text, cboNhaCungCap.SelectedValue.ToString(), taiKhoan.TK_NhanVien))
                        {
                            MessageBox.Show("Cập nhật nguyên liệu thành công");
                            loadIncredientTable();
                        }
                    }
                    catch
                    {
                        Message.Message.showFailedDBExecution("sửa nguyên liệu", "nguyên liệu");
                    }
                    finally
                    {
                        btnLuu.Enabled = IsAdd = false;
                    }
                }
            }
        }

        public bool checkUserInputForAdding()
        {
            if("0".Equals(cboNhaCungCap.SelectedValue.ToString()))
            {
                Message.Message.showMissingInfoMessage("nhà cung cấp", "thêm nguyên liệu");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenNL.Text))
            {
                Message.Message.showMissingInfoMessage("tên nguyên liệu", "thêm nguyên liệu");
                return false;
            }

            if(string.IsNullOrEmpty(txtDonGia.Text))
            {
                txtDonGia.Text = "0";
            }
            return true;
        }

        public bool checkUserInputForAdjusting()
        {
            if ("0".Equals(cboNhaCungCap.SelectedValue.ToString()))
            {
                Message.Message.showMissingInfoMessage("nhà cung cấp", "cập nhật nguyên liệu");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenNL.Text))
            {
                Message.Message.showMissingInfoMessage("tên nguyên liệu", "cập nhật nguyên liệu");
                return false;
            }

            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                txtDonGia.Text = "0";
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string nl_id = txtId.Text;
            if (string.IsNullOrEmpty(nl_id)){
                Message.Message.showMissingInfoMessage("mã nguyên liệu", "xóa nguyên liệu");
                return;
            } else
            {
                try { 
                    if(nguyenLieu.delete(nl_id, taiKhoan.TK_NhanVien))
                    {
                        MessageBox.Show("Xóa nguyên liệu thành công");
                        loadIncredientTable();
                    }
                }
                catch
                {
                    Message.Message.showFailedDBExecution("xóa nguyên liệu", "nguyên liệu");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            IsAdd = false;
            btnLuu.Enabled = true;
        }
    }
}
