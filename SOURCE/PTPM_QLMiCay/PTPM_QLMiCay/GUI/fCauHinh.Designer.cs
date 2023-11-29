namespace PTPM_QLMiCay.GUI
{
    partial class fCauHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinh));
            this.btnLuu = new CustomControl.ControlCustom.CButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtMK = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.cboServer = new CustomControl.ControlCustom.CCombobox();
            this.cLable3 = new CustomControl.ControlCustom.CLable();
            this.cboDatabase = new CustomControl.ControlCustom.CCombobox();
            this.cLable4 = new CustomControl.ControlCustom.CLable();
            this.btnHuy = new CustomControl.ControlCustom.CButton();
            this.txtUser = new CustomControl.ControlCustom.CTextBox();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.ActiveBorderThickness = 1;
            this.btnLuu.ActiveCornerRadius = 20;
            this.btnLuu.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnLuu.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuu.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLuu.ForeColor = System.Drawing.Color.Orange;
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleCornerRadius = 20;
            this.btnLuu.IdleFillColor = System.Drawing.Color.White;
            this.btnLuu.IdleForecolor = System.Drawing.Color.Orange;
            this.btnLuu.IdleLineColor = System.Drawing.Color.Orange;
            this.btnLuu.Location = new System.Drawing.Point(289, 398);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(178, 41);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(289, 355);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(370, 35);
            this.bunifuSeparator2.TabIndex = 14;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.White;
            this.txtMK.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtMK.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtMK.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtMK.BorderThickness = 1;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMK.isPassword = true;
            this.txtMK.Location = new System.Drawing.Point(289, 246);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(370, 29);
            this.txtMK.TabIndex = 9;
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(285, 161);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(88, 21);
            this.cLable2.TabIndex = 13;
            this.cLable2.Text = "User Name";
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(285, 101);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(101, 21);
            this.cLable1.TabIndex = 12;
            this.cLable1.Text = "Server Name";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(289, 75);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(370, 35);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(282, 39);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(127, 38);
            this.cLableTitle1.TabIndex = 8;
            this.cLableTitle1.Text = "Cấu hình";
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.ItemHeight = 23;
            this.cboServer.Location = new System.Drawing.Point(289, 125);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(370, 29);
            this.cboServer.TabIndex = 15;
            this.cboServer.UseSelectable = true;
            // 
            // cLable3
            // 
            this.cLable3.AutoSize = true;
            this.cLable3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable3.ForeColor = System.Drawing.Color.Orange;
            this.cLable3.Location = new System.Drawing.Point(283, 221);
            this.cLable3.Name = "cLable3";
            this.cLable3.Size = new System.Drawing.Size(76, 21);
            this.cLable3.TabIndex = 17;
            this.cLable3.Text = "Password";
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.ItemHeight = 23;
            this.cboDatabase.Location = new System.Drawing.Point(287, 317);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(370, 29);
            this.cboDatabase.TabIndex = 19;
            this.cboDatabase.UseSelectable = true;
            this.cboDatabase.DropDown += new System.EventHandler(this.cboDatabase_DropDown);
            // 
            // cLable4
            // 
            this.cLable4.AutoSize = true;
            this.cLable4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable4.ForeColor = System.Drawing.Color.Orange;
            this.cLable4.Location = new System.Drawing.Point(283, 293);
            this.cLable4.Name = "cLable4";
            this.cLable4.Size = new System.Drawing.Size(120, 21);
            this.cLable4.TabIndex = 18;
            this.cLable4.Text = "Database Name";
            // 
            // btnHuy
            // 
            this.btnHuy.ActiveBorderThickness = 1;
            this.btnHuy.ActiveCornerRadius = 20;
            this.btnHuy.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnHuy.ActiveForecolor = System.Drawing.Color.White;
            this.btnHuy.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.Orange;
            this.btnHuy.IdleBorderThickness = 1;
            this.btnHuy.IdleCornerRadius = 20;
            this.btnHuy.IdleFillColor = System.Drawing.Color.White;
            this.btnHuy.IdleForecolor = System.Drawing.Color.Orange;
            this.btnHuy.IdleLineColor = System.Drawing.Color.Orange;
            this.btnHuy.Location = new System.Drawing.Point(481, 398);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(178, 41);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtUser.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtUser.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtUser.BorderThickness = 1;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.isPassword = false;
            this.txtUser.Location = new System.Drawing.Point(289, 188);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(370, 29);
            this.txtUser.TabIndex = 21;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 483);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.cLable4);
            this.Controls.Add(this.cLable3);
            this.Controls.Add(this.cboServer);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.cLable2);
            this.Controls.Add(this.cLable1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cLableTitle1);
            this.Name = "fCauHinh";
            this.Text = "fCauHinh";
            this.Load += new System.EventHandler(this.fCauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.ControlCustom.CButton btnLuu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private CustomControl.ControlCustom.CTextBox txtMK;
        private CustomControl.ControlCustom.CLable cLable2;
        private CustomControl.ControlCustom.CLable cLable1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private CustomControl.ControlCustom.CCombobox cboServer;
        private CustomControl.ControlCustom.CLable cLable3;
        private CustomControl.ControlCustom.CCombobox cboDatabase;
        private CustomControl.ControlCustom.CLable cLable4;
        private CustomControl.ControlCustom.CButton btnHuy;
        private CustomControl.ControlCustom.CTextBox txtUser;
    }
}