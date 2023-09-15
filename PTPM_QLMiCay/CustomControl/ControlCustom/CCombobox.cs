using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CCombobox : MetroComboBox
    {
        public CCombobox() 
        {
            this.Size = new Size(203, 29);
            this.Margin = new Padding(3,3,3,3);

        }
    }
}
