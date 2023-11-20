using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace FormControl
{
    public partial class UFNhomQuyen : UserControl
    {
        DAL_CapQuyenNhom capQuyenNhom = new DAL_CapQuyenNhom();
        DAL_NhomQuyen nhomQuyen = new DAL_NhomQuyen();
        DAL_Quyen quyen = new DAL_Quyen();

        public UFNhomQuyen()
        {
            InitializeComponent();
            loadCBB();
        }

        public void loadDGV(string NQID)
        {
            if (dgv_Quyen.Rows.Count>0)
                dgv_Quyen.Rows.Clear();
            dgv_Quyen.DataSource = capQuyenNhom.load(dgv_Quyen, NQID).DataSource;
        }
        public void loadTextBox(string NQID)
        {
            NhomQuyen nq = nhomQuyen.loadSingleNhomQuyen(NQID);
            if (nq != null)
            {
                txt_NQID.Text = nq.NQ_Id.ToString(); ;
                txt_TenNQ.Text = nq.NQ_Ten;
                txt_HienThi.Text = nq.NQ_HienThi;
            }
        }
        public void loadCBB()
        {
            cbb_NQ.DataSource = nhomQuyen.loadNhomQuyen();
            cbb_NQ.DisplayMember = "NQ_HienThi";
            cbb_NQ.ValueMember = "NQ_Id";
            cbb_NQ.SelectedIndex = 0;

            loadDGV(cbb_NQ.SelectedValue.ToString());
            loadTextBox(cbb_NQ.SelectedValue.ToString());
        }
        public void clearTextBox()
        {
            txt_NQID.Text = string.Empty;
            txt_TenNQ.Text = string.Empty;
            txt_HienThi.Text = string.Empty;
        }

        private void btn_ThemNQ_Click(object sender, EventArgs e)
        {
            if (!btn_GanQuyen.ButtonText.Equals("HỦY"))
            {
                txt_NQID.Enabled = true;
                txt_TenNQ.Enabled = true;
                txt_HienThi.Enabled = true;

                btn_SuaNQ.Enabled = false;
                btn_XoaNQ.Enabled = false;
                cbb_NQ.Enabled = false;
                btn_GanQuyen.ButtonText = "HỦY";
            }
            else
            {
                string id = txt_NQID.Text;
                string ten = txt_TenNQ.Text;
                string hienThi = txt_HienThi.Text;

                if (nhomQuyen.loadSingleNhomQuyen(id) == null)
                {
                    if (nhomQuyen.addNhomQuyen(id, ten, hienThi))
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo");
                        loadCBB();

                        txt_NQID.Enabled = false;
                        txt_TenNQ.Enabled = false;
                        txt_HienThi.Enabled = false;

                        btn_SuaNQ.Enabled = true;
                        btn_XoaNQ.Enabled = true;
                        cbb_NQ.Enabled = true;

                        btn_GanQuyen.ButtonText = "Gán quyền";
                    }
                    else
                        MessageBox.Show("Thêm thất bại", "Thông Báo");
                }
                else
                    MessageBox.Show("ID nhóm quyền đã tồn tại", "Thông Báo");
            }

        }

        private void btn_XoaNQ_Click(object sender, EventArgs e)
        {
            string id = txt_NQID.Text;
            if (MessageBox.Show("Xác nhận xóa nhóm quyền " + id, "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (nhomQuyen.deleteNhomQuyen(id))
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    loadCBB();
                }
                else
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
            }

        }

        private void btn_SuaNQ_Click(object sender, EventArgs e)
        {
            if (!btn_GanQuyen.ButtonText.Equals("HỦY"))
            {
                txt_TenNQ.Enabled = true;
                txt_HienThi.Enabled = true;

                btn_ThemNQ.Enabled = false;
                btn_XoaNQ.Enabled = false;
                cbb_NQ.Enabled = false;
                btn_GanQuyen.ButtonText = "HỦY";
            }
            else
            {
                string id = txt_NQID.Text;
                string ten = txt_TenNQ.Text;
                string hienThi = txt_HienThi.Text;

                if (nhomQuyen.updateNhomQuyen(id, ten, hienThi))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                    loadCBB();

                    txt_TenNQ.Enabled = false;
                    txt_HienThi.Enabled = false;

                    btn_ThemNQ.Enabled = true;
                    btn_XoaNQ.Enabled = true;
                    cbb_NQ.Enabled = true;

                    btn_GanQuyen.ButtonText = "Gán quyền";
                }
                else
                    MessageBox.Show("Sửa thất bại", "Thông Báo");
            }
        }

        private void btn_GanQuyen_Click(object sender, EventArgs e)
        {
            if (btn_GanQuyen.ButtonText.Equals("HỦY"))
            {
                loadTextBox(cbb_NQ.SelectedValue.ToString());
                txt_NQID.Enabled = false;
                txt_TenNQ.Enabled = false;
                txt_HienThi.Enabled = false;

                btn_SuaNQ.Enabled = true;
                btn_XoaNQ.Enabled = true;
                cbb_NQ.Enabled = true;

                btn_GanQuyen.ButtonText = "Gán quyền";
            }
            else
            {
                string id = txt_NQID.Text;
                List<CapQuyenNhom> cqn = capQuyenNhom.laySeletedQuyenManHinh(id, dgv_Quyen);
                if (capQuyenNhom.addCapQuyenNhom(cqn))
                {
                    MessageBox.Show("Gán quyền thành công", "Thông Báo");
                    loadDGV(cbb_NQ.SelectedValue.ToString());
                }
                else
                    MessageBox.Show("Gán quyền thất bại", "Thông Báo");
            }
        }

        private void cbb_NQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGV(cbb_NQ.SelectedValue.ToString());
            loadTextBox(cbb_NQ.SelectedValue.ToString());
        }

        private void UFNhomQuyen_Load(object sender, EventArgs e)
        {

        }
    }

}
