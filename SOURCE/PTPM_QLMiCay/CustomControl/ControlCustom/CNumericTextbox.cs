using Bunifu.Framework.UI;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CNumericTextbox : BunifuMetroTextbox
    {
        public CNumericTextbox()
        {
            this.BackColor = Color.White;
            this.BorderColorFocused = Color.Orange;
            this.BorderColorIdle = Color.Orange;
            this.BorderColorMouseHover = Color.Orange;
            this.Font = new Font("Century Gothic", 10);
            this.BorderThickness = 1;
            this.TabIndex = 0;
            this.Size = new Size(203, 29);
            this.KeyPress += CNumericTextbox_KeyPress;
        }

        private void CNumericTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
