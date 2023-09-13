using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
