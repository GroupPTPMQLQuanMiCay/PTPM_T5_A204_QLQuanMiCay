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
    public partial class UFQuyen : UserControl
    {
        DAL_NguoiDung nguoiDung = new DAL_NguoiDung();
        DAL_NhomQuyen nhomQuyen = new DAL_NhomQuyen();
        DAL_ManHinh manHinh = new DAL_ManHinh();
        DAL_NhomQuyen_NguoiDung nhomQuyen_nguoiDung = new DAL_NhomQuyen_NguoiDung();
        public event EventHandler ShowNhomQuyen;
        public UFQuyen()
        {
            InitializeComponent();
            loadCBB();
        }

        public void loadCBB()
        {
            cbb_ChucVu.DataSource = nguoiDung.load();
            cbb_ChucVu.DisplayMember = "NG_PhongBan";
            cbb_ChucVu.ValueMember = "NG_Id";
            cbb_ChucVu.SelectedIndex = 0;

            loadDGV(cbb_ChucVu.SelectedValue.ToString());
        }

        public void loadDGV(string NGID)
        {
            if (dgv_NQ.Rows.Count != 0)
                dgv_NQ.Rows.Clear();
            dgv_NQ.DataSource = nhomQuyen_nguoiDung.load(dgv_NQ, NGID).DataSource;

        }

        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            string id = cbb_ChucVu.SelectedValue.ToString();
            List<string> nhomQuyenIDs = nhomQuyen.getListNhomQuyenSelected(dgv_NQ);
            if (nhomQuyen_nguoiDung.addNhomQuyen_NguoiDung(id, nhomQuyenIDs))
            {
                MessageBox.Show("Phân quyền thành công", "Thông Báo");
                loadDGV(cbb_ChucVu.SelectedValue.ToString());
            }
            else
                MessageBox.Show("Phân quyền thất bại", "Thông Báo");
        }

        private void cbb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGV(cbb_ChucVu.SelectedValue.ToString());
        }

        private void btn_NQ_Click(object sender, EventArgs e)
        {
            ShowNhomQuyen.Invoke(this, EventArgs.Empty);
        }


    }
}
