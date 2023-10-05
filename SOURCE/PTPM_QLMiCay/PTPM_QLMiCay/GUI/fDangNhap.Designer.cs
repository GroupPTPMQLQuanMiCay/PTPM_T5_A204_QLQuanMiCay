

namespace PTPM_QLMiCay.GUI
{
    partial class fDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.cButtonClose1 = new CustomControl.ControlCustom.CButtonClose();
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.cTextBox1 = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.cTextBox2 = new CustomControl.ControlCustom.CTextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cButton1 = new CustomControl.ControlCustom.CButton();
            this.cButton2 = new CustomControl.ControlCustom.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.cButtonClose1)).BeginInit();
            this.SuspendLayout();
            // 
            // cButtonClose1
            // 
            this.cButtonClose1.BackColor = System.Drawing.Color.White;
            this.cButtonClose1.Image = ((System.Drawing.Image)(resources.GetObject("cButtonClose1.Image")));
            this.cButtonClose1.ImageActive = null;
            this.cButtonClose1.Location = new System.Drawing.Point(916, 2);
            this.cButtonClose1.Name = "cButtonClose1";
            this.cButtonClose1.Size = new System.Drawing.Size(20, 20);
            this.cButtonClose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cButtonClose1.TabIndex = 0;
            this.cButtonClose1.TabStop = false;
            this.cButtonClose1.Zoom = 10;
            this.cButtonClose1.Click += new System.EventHandler(this.cButtonClose1_Click);
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(514, 28);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(153, 38);
            this.cLableTitle1.TabIndex = 1;
            this.cLableTitle1.Text = "Đăng nhập";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(463, 479);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(521, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(370, 35);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(517, 111);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(116, 21);
            this.cLable1.TabIndex = 4;
            this.cLable1.Text = "Tên Đăng Nhập";
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.Color.White;
            this.cTextBox1.BorderColorFocused = System.Drawing.Color.Orange;
            this.cTextBox1.BorderColorIdle = System.Drawing.Color.Orange;
            this.cTextBox1.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.cTextBox1.BorderThickness = 1;
            this.cTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cTextBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTextBox1.isPassword = false;
            this.cTextBox1.Location = new System.Drawing.Point(521, 136);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Size = new System.Drawing.Size(370, 29);
            this.cTextBox1.TabIndex = 0;
            this.cTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(517, 193);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(76, 21);
            this.cLable2.TabIndex = 5;
            this.cLable2.Text = "Mật Khẩu";
            // 
            // cTextBox2
            // 
            this.cTextBox2.BackColor = System.Drawing.Color.White;
            this.cTextBox2.BorderColorFocused = System.Drawing.Color.Orange;
            this.cTextBox2.BorderColorIdle = System.Drawing.Color.Orange;
            this.cTextBox2.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.cTextBox2.BorderThickness = 1;
            this.cTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cTextBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTextBox2.isPassword = true;
            this.cTextBox2.Location = new System.Drawing.Point(521, 218);
            this.cTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Size = new System.Drawing.Size(370, 29);
            this.cTextBox2.TabIndex = 0;
            this.cTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(521, 266);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(370, 35);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // cButton1
            // 
            this.cButton1.ActiveBorderThickness = 1;
            this.cButton1.ActiveCornerRadius = 20;
            this.cButton1.ActiveFillColor = System.Drawing.Color.Orange;
            this.cButton1.ActiveForecolor = System.Drawing.Color.White;
            this.cButton1.ActiveLineColor = System.Drawing.Color.Orange;
            this.cButton1.BackColor = System.Drawing.Color.White;
            this.cButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cButton1.BackgroundImage")));
            this.cButton1.ButtonText = "Đăng Nhập";
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton1.ForeColor = System.Drawing.Color.Orange;
            this.cButton1.IdleBorderThickness = 1;
            this.cButton1.IdleCornerRadius = 20;
            this.cButton1.IdleFillColor = System.Drawing.Color.White;
            this.cButton1.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton1.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton1.Location = new System.Drawing.Point(521, 309);
            this.cButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(370, 41);
            this.cButton1.TabIndex = 22;
            this.cButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cButton2
            // 
            this.cButton2.ActiveBorderThickness = 1;
            this.cButton2.ActiveCornerRadius = 20;
            this.cButton2.ActiveFillColor = System.Drawing.Color.Orange;
            this.cButton2.ActiveForecolor = System.Drawing.Color.White;
            this.cButton2.ActiveLineColor = System.Drawing.Color.Orange;
            this.cButton2.BackColor = System.Drawing.Color.White;
            this.cButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cButton2.BackgroundImage")));
            this.cButton2.ButtonText = "Thoát";
            this.cButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton2.ForeColor = System.Drawing.Color.Orange;
            this.cButton2.IdleBorderThickness = 1;
            this.cButton2.IdleCornerRadius = 20;
            this.cButton2.IdleFillColor = System.Drawing.Color.White;
            this.cButton2.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton2.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton2.Location = new System.Drawing.Point(521, 360);
            this.cButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(370, 41);
            this.cButton2.TabIndex = 22;
            this.cButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 483);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.cTextBox2);
            this.Controls.Add(this.cLable2);
            this.Controls.Add(this.cTextBox1);
            this.Controls.Add(this.cLable1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.cLableTitle1);
            this.Controls.Add(this.cButtonClose1);
            this.Name = "fDangNhap";
            this.Text = "fDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.cButtonClose1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.ControlCustom.CButtonClose cButtonClose1;
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CustomControl.ControlCustom.CLable cLable1;
        private CustomControl.ControlCustom.CTextBox cTextBox1;
        private CustomControl.ControlCustom.CLable cLable2;
        private CustomControl.ControlCustom.CTextBox cTextBox2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private CustomControl.ControlCustom.CButton cButton1;
        private CustomControl.ControlCustom.CButton cButton2;
    }
}