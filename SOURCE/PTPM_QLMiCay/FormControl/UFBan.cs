using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormControl.Forms;

namespace FormControl
{
    public partial class UFBan : UserControl
    {
        public UFBan()
        {
            InitializeComponent();
        }

        private void btnChinhSuaBan_Click(object sender, EventArgs e)
        {
            frmChinhSuaBan frm = new frmChinhSuaBan();
            frm.Show();
        }
    }
}
