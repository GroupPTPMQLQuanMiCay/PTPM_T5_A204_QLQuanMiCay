using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CGroupBox : GroupBox
    {
        public CGroupBox()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Orange;
            this.Font = new Font("Segoe UI", 12);
            this.Margin = new Padding(3,3,3,3);


        }
    }
}
