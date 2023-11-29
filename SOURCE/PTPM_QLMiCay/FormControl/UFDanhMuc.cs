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
    public partial class UFDanhMuc : UserControl
    {
        DAL_DanhMuc dm = new DAL_DanhMuc();
        public UFDanhMuc()
        {
            InitializeComponent();
        }
        

        private void UFDanhMuc_Load(object sender, EventArgs e)
        {
            dgvDM.DataSource = dm.LoadAllDM();
        }

        private void dgvDM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDM.Text = dgvDM.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDM.Text = dgvDM.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
        }
    }
}
