using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    }
}
