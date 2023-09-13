using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CButton : BunifuThinButton2
    {
       public CButton() 
       {
            this.ForeColor = Color.Orange;
            this.Font = new Font("Segoe UI", 12);
            this.Margin = new Padding(4,5,4,5);
            this.TabIndex = 22;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.IdleBorderThickness = 1;
            this.IdleCornerRadius = 20;
            this.ActiveFillColor = Color.Orange;
            this.ActiveLineColor = Color.Orange;
            this.IdleForecolor = Color.Orange;
            this.IdleLineColor = Color.Orange;
        }
    }
}
