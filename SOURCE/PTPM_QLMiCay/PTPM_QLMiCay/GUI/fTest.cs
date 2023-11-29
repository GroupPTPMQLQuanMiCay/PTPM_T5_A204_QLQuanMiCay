using CustomControl.FormCustom;
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


namespace PTPM_QLMiCay.GUI
{
    public partial class fTest : FormEntity
    {
        DAL_Ban banDAL = new DAL_Ban();
        public fTest()
        {
            InitializeComponent();
            cCombobox1.Text = "Test nè bây";
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            bantest.DataSource = banDAL.loadBanALL();
        }
    }
}
