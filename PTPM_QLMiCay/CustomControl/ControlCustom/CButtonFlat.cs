using Bunifu.Framework.UI;
using System.Drawing;

namespace CustomControl.ControlCustom
{
    public class CButtonFlat : BunifuFlatButton
    {
        public CButtonFlat() 
        {
            this.Normalcolor = Color.Orange;
            this.OnHovercolor = Color.OrangeRed;
            this.Activecolor = Color.Orange;
            this.BackColor = Color.Orange;
            this.TextFont = new Font("Segoe UI", 10);
            this.Textcolor = Color.Black;
            //this.TabIndex = 5;

        }
    }
}
