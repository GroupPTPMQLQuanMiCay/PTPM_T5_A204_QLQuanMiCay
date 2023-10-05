using System.Drawing;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CLable : Label
    {
        public CLable() 
        {
            this.ForeColor = Color.Orange;
            this.Font = new Font("Segoe UI", 12);
            
        }
    }
}
