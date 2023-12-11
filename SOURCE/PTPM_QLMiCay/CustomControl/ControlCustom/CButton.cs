using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CustomControl.ControlCustom
{
    public class CButton : BunifuThinButton2
    {
       public CButton() 
       {
            this.ForeColor = Color.FromArgb(128, 128, 255);
            this.Font = new Font("Segoe UI", 13);
            this.Margin = new Padding(4,5,4,5);
            this.TabIndex = 22;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.IdleBorderThickness = 1;
            this.IdleCornerRadius = 20;
            this.ActiveFillColor = Color.FromArgb(128, 128, 255);
            this.ActiveLineColor = Color.FromArgb(128, 128, 255);
            this.IdleForecolor = Color.FromArgb(128, 128, 255);
            this.IdleLineColor = Color.FromArgb(128, 128, 255);
        }
    }
}
