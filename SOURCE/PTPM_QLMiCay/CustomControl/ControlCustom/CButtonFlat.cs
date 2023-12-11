using Bunifu.Framework.UI;
using System.Drawing;

namespace CustomControl.ControlCustom
{
    public class CButtonFlat : BunifuFlatButton
    {
        public CButtonFlat() 
        {
            this.Normalcolor = Color.FromArgb(128, 128, 255);
            this.Activecolor = Color.FromArgb(110, 132, 163);
            this.BackColor = Color.White;
            this.TextFont = new Font("Segoe UI", 13);
            this.Textcolor = Color.White;
        }
    }
}
