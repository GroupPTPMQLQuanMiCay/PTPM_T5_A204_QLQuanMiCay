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
    }
}
