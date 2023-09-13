using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
