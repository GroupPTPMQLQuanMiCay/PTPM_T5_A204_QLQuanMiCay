using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
