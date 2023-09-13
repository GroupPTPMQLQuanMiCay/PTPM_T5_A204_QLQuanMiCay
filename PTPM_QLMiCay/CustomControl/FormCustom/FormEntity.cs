using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControl.FormCustom
{
    public class FormEntity : Form
    {
        public Point mouseLocation;

        public FormEntity() 
        { 
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += FormEntity_MouseDown;
            this.MouseMove += FormEntity_MouseMove;
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

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormEntity
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "FormEntity";
        //    this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
        //    this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
        //    this.ResumeLayout(false);

        //}

        //private void mouse_Down(object sender, MouseEventArgs e)
        //{
        //    mouseLocation = new Point(-e.X, -e.Y);

        //}

        //private void mouse_Move(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        Point mousePose = Control.MousePosition;
        //        mousePose.Offset(mouseLocation.X, mouseLocation.Y);
        //        Location = mousePose;
        //    }

        //}
    }
}
