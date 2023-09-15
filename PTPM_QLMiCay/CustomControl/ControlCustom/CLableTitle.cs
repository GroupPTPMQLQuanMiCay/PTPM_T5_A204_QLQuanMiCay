using System.Drawing;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CLableTitle : Label
    {
        public CLableTitle() 
        {
            this.ForeColor = Color.Orange;
            this.Font = new Font("Segoe UI", 21);
            this.Font = new Font(this.Font, FontStyle.Regular);
        }
    }
}
