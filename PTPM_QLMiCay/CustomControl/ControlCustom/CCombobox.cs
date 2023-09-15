using MetroFramework.Controls;
using System.Drawing;
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
