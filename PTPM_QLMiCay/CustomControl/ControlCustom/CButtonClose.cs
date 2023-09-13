using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControl.ControlCustom
{
    public class CButtonClose : BunifuImageButton
    {
        public CButtonClose()
        {
            this.SizeMode = PictureBoxSizeMode.Normal;
            this.BackColor = Color.White;
            this.Size = new Size(20, 20);
            this.Click += CButtonClose_Click;
        }

        private void CButtonClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
