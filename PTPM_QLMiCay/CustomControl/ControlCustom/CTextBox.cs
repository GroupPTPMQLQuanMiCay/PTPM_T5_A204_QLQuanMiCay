using Bunifu.Framework.UI;
using System.Drawing;

namespace CustomControl.ControlCustom
{
    public class CTextBox : BunifuMetroTextbox
    {
        public CTextBox() 
        {   
            this.BackColor = Color.White;
            this.BorderColorFocused = Color.Orange;
            this.BorderColorIdle = Color.Orange;
            this.BorderColorMouseHover = Color.Orange;
            this.Font = new Font("Century Gothic", 10);
            this.BorderThickness = 1;
            this.TabIndex = 0;
            this.Size=new Size(203, 29);
        }
    }
}
