using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CustomControl.ControlCustom;

namespace CustomControl.FormCustom
{
    public class FormEntity : Form
    {
        public Point mouseLocation;
        

        public FormEntity() 
        { 
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += FormEntity_MouseDown;
            this.MouseMove += FormEntity_MouseMove;
            //this.Size = new Size(1207, 700);
        }

        private void FormEntity_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void FormEntity_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
