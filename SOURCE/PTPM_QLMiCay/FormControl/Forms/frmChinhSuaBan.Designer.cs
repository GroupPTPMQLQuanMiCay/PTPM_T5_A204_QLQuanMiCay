namespace FormControl.Forms
{
    partial class frmChinhSuaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinhSuaBan));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.txtNhaCungCap = new CustomControl.ControlCustom.CTextBox();
            this.txtID = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.btnSua = new CustomControl.ControlCustom.CButton();
            this.btnXoa = new CustomControl.ControlCustom.CButton();
            this.btnThem = new CustomControl.ControlCustom.CButton();
            this.cGroupBox3 = new CustomControl.ControlCustom.CGroupBox();
            this.dgvDSachBan = new CustomControl.ControlCustom.CDataGirdView();
            this.cGroupBox1.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            this.cGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSachBan)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 50);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(861, 12);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(3, 9);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(63, 38);
            this.cLableTitle1.TabIndex = 18;
            this.cLableTitle1.Text = "Bàn";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.txtNhaCungCap);
            this.cGroupBox1.Controls.Add(this.txtID);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Controls.Add(this.cLable1);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(12, 68);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(227, 158);
            this.cGroupBox1.TabIndex = 20;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông tin bàn";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.BackColor = System.Drawing.Color.White;
            this.txtNhaCungCap.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtNhaCungCap.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtNhaCungCap.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtNhaCungCap.BorderThickness = 1;
            this.txtNhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCungCap.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNhaCungCap.isPassword = false;
            this.txtNhaCungCap.Location = new System.Drawing.Point(7, 118);
            this.txtNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(203, 29);
            this.txtNhaCungCap.TabIndex = 15;
            this.txtNhaCungCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtID.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtID.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtID.BorderThickness = 1;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.isPassword = false;
            this.txtID.Location = new System.Drawing.Point(7, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(203, 29);
            this.txtID.TabIndex = 12;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(7, 25);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(61, 21);
            this.cLable2.TabIndex = 14;
            this.cLable2.Text = "Số bàn:";
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(6, 89);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(46, 21);
            this.cLable1.TabIndex = 13;
            this.cLable1.Text = "Vị trí:";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.btnSua);
            this.cGroupBox2.Controls.Add(this.btnXoa);
            this.cGroupBox2.Controls.Add(this.btnThem);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(11, 232);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(228, 204);
            this.cGroupBox2.TabIndex = 21;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.ActiveBorderThickness = 1;
            this.btnSua.ActiveCornerRadius = 20;
            this.btnSua.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnSua.ActiveForecolor = System.Drawing.Color.White;
            this.btnSua.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.Orange;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.Color.White;
            this.btnSua.IdleForecolor = System.Drawing.Color.Orange;
            this.btnSua.IdleLineColor = System.Drawing.Color.Orange;
            this.btnSua.Location = new System.Drawing.Point(33, 132);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(163, 41);
            this.btnSua.TabIndex = 22;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 20;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.Orange;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.White;
            this.btnXoa.IdleForecolor = System.Drawing.Color.Orange;
            this.btnXoa.IdleLineColor = System.Drawing.Color.Orange;
            this.btnXoa.Location = new System.Drawing.Point(33, 81);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 41);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 20;
            this.btnThem.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnThem.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.Orange;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.White;
            this.btnThem.IdleForecolor = System.Drawing.Color.Orange;
            this.btnThem.IdleLineColor = System.Drawing.Color.Orange;
            this.btnThem.Location = new System.Drawing.Point(33, 30);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 41);
            this.btnThem.TabIndex = 22;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cGroupBox3
            // 
            this.cGroupBox3.BackColor = System.Drawing.Color.White;
            this.cGroupBox3.Controls.Add(this.dgvDSachBan);
            this.cGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox3.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox3.Location = new System.Drawing.Point(264, 78);
            this.cGroupBox3.Name = "cGroupBox3";
            this.cGroupBox3.Size = new System.Drawing.Size(608, 358);
            this.cGroupBox3.TabIndex = 22;
            this.cGroupBox3.TabStop = false;
            this.cGroupBox3.Text = "Danh sách bàn";
            // 
            // dgvDSachBan
            // 
            this.dgvDSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSachBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSachBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSachBan.GridColor = System.Drawing.Color.White;
            this.dgvDSachBan.Location = new System.Drawing.Point(3, 25);
            this.dgvDSachBan.Name = "dgvDSachBan";
            this.dgvDSachBan.RowHeadersVisible = false;
            this.dgvDSachBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSachBan.Size = new System.Drawing.Size(602, 330);
            this.dgvDSachBan.TabIndex = 0;
            // 
            // frmChinhSuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 462);
            this.Controls.Add(this.cGroupBox3);
            this.Controls.Add(this.cGroupBox2);
            this.Controls.Add(this.cGroupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cLableTitle1);
            this.Name = "frmChinhSuaBan";
            this.Text = "frmChinhSuaBan";
            this.Load += new System.EventHandler(this.frmChinhSuaBan_Load);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.cGroupBox2.ResumeLayout(false);
            this.cGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSachBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CTextBox txtNhaCungCap;
        private CustomControl.ControlCustom.CTextBox txtID;
        private CustomControl.ControlCustom.CLable cLable2;
        private CustomControl.ControlCustom.CLable cLable1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CButton btnSua;
        private CustomControl.ControlCustom.CButton btnXoa;
        private CustomControl.ControlCustom.CButton btnThem;
        private CustomControl.ControlCustom.CGroupBox cGroupBox3;
        private CustomControl.ControlCustom.CDataGirdView dgvDSachBan;
    }
}