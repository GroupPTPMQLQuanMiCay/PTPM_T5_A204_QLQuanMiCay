using System;

using CustomControl.FormCustom;
using BLL_DAL;
using CustomControl.ControlCustom;
namespace FormControl.Forms
{
    public partial class frmChinhSuaBan : FormEntity
    {

        DAL_Ban banDAL = new DAL_Ban();
        public frmChinhSuaBan()
        {
            InitializeComponent();
        }

        private void frmChinhSuaBan_Load(object sender, EventArgs e)
        {
            dgvDSachBan.DataSource = banDAL.loadBanALL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
