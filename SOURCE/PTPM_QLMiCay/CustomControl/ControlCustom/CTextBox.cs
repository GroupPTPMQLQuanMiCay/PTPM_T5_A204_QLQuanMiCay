using Bunifu.Framework.UI;
using System.Drawing;

namespace CustomControl.ControlCustom
{
    public class CTextBox : BunifuMetroTextbox
    {
        public CTextBox() 
        {   
            this.BackColor = Color.White;
            this.BorderColorFocused = Color.FromArgb(128, 128, 255); 
            this.BorderColorIdle = Color.FromArgb(128, 128, 255);
            this.BorderColorMouseHover = Color.FromArgb(128, 128, 255);
            this.Font = new Font("Segoe UI", 13);
            this.BorderThickness = 1;
            this.TabIndex = 0;
            this.Size=new Size(203, 29);
        }
    }
}
