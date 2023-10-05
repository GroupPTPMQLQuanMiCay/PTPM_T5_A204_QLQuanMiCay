using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

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
