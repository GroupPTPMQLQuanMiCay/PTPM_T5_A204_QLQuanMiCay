namespace FormControl.Forms
{
    partial class frmChonMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonMon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.dgvOD = new CustomControl.ControlCustom.CDataGirdView();
            this.STT_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.txtBan = new CustomControl.ControlCustom.CTextBox();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.btnThanhToan = new CustomControl.ControlCustom.CButton();
            this.btnGoiMon = new CustomControl.ControlCustom.CButton();
            this.txtThanhTien = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.fpnelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOD)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cGroupBox2);
            this.panel1.Controls.Add(this.cGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 699);
            this.panel1.TabIndex = 0;
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.dgvOD);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(12, 3);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(433, 262);
            this.cGroupBox2.TabIndex = 2;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Chi tiết gọi món";
            // 
            // dgvOD
            // 
            this.dgvOD.AllowUserToAddRows = false;
            this.dgvOD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOD.BackgroundColor = System.Drawing.Color.White;
            this.dgvOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_Mon,
            this.Ten_Mon,
            this.DonGia,
            this.SoLuong,
            this.Gia});
            this.dgvOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOD.GridColor = System.Drawing.Color.White;
            this.dgvOD.Location = new System.Drawing.Point(3, 25);
            this.dgvOD.Name = "dgvOD";
            this.dgvOD.RowHeadersVisible = false;
            this.dgvOD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOD.Size = new System.Drawing.Size(427, 234);
            this.dgvOD.TabIndex = 0;
            this.dgvOD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOD_CellEndEdit);
            // 
            // STT_Mon
            // 
            this.STT_Mon.HeaderText = "STT";
            this.STT_Mon.Name = "STT_Mon";
            // 
            // Ten_Mon
            // 
            this.Ten_Mon.HeaderText = "Tên";
            this.Ten_Mon.Name = "Ten_Mon";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.txtBan);
            this.cGroupBox1.Controls.Add(this.cLable1);
            this.cGroupBox1.Controls.Add(this.btnThanhToan);
            this.cGroupBox1.Controls.Add(this.btnGoiMon);
            this.cGroupBox1.Controls.Add(this.txtThanhTien);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(12, 271);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(433, 193);
            this.cGroupBox1.TabIndex = 1;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông tin chi tiết";
            // 
            // txtBan
            // 
            this.txtBan.BackColor = System.Drawing.Color.White;
            this.txtBan.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtBan.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtBan.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtBan.BorderThickness = 1;
            this.txtBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBan.Enabled = false;
            this.txtBan.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBan.isPassword = false;
            this.txtBan.Location = new System.Drawing.Point(26, 65);
            this.txtBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(182, 32);
            this.txtBan.TabIndex = 0;
            this.txtBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(22, 40);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(36, 21);
            this.cLable1.TabIndex = 23;
            this.cLable1.Text = "Bàn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.ActiveBorderThickness = 1;
            this.btnThanhToan.ActiveCornerRadius = 20;
            this.btnThanhToan.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnThanhToan.ActiveForecolor = System.Drawing.Color.White;
            this.btnThanhToan.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.BackgroundImage")));
            this.btnThanhToan.ButtonText = "Thanh toán";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Orange;
            this.btnThanhToan.IdleBorderThickness = 1;
            this.btnThanhToan.IdleCornerRadius = 20;
            this.btnThanhToan.IdleFillColor = System.Drawing.Color.White;
            this.btnThanhToan.IdleForecolor = System.Drawing.Color.Orange;
            this.btnThanhToan.IdleLineColor = System.Drawing.Color.Orange;
            this.btnThanhToan.Location = new System.Drawing.Point(229, 127);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(176, 41);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.ActiveBorderThickness = 1;
            this.btnGoiMon.ActiveCornerRadius = 20;
            this.btnGoiMon.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnGoiMon.ActiveForecolor = System.Drawing.Color.White;
            this.btnGoiMon.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnGoiMon.BackColor = System.Drawing.Color.White;
            this.btnGoiMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoiMon.BackgroundImage")));
            this.btnGoiMon.ButtonText = "Gọi món";
            this.btnGoiMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoiMon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGoiMon.ForeColor = System.Drawing.Color.Orange;
            this.btnGoiMon.IdleBorderThickness = 1;
            this.btnGoiMon.IdleCornerRadius = 20;
            this.btnGoiMon.IdleFillColor = System.Drawing.Color.White;
            this.btnGoiMon.IdleForecolor = System.Drawing.Color.Orange;
            this.btnGoiMon.IdleLineColor = System.Drawing.Color.Orange;
            this.btnGoiMon.Location = new System.Drawing.Point(22, 127);
            this.btnGoiMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(176, 41);
            this.btnGoiMon.TabIndex = 22;
            this.btnGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtThanhTien.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtThanhTien.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtThanhTien.BorderThickness = 1;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThanhTien.isPassword = false;
            this.txtThanhTien.Location = new System.Drawing.Point(229, 65);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(179, 32);
            this.txtThanhTien.TabIndex = 6;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(225, 40);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(86, 21);
            this.cLable2.TabIndex = 7;
            this.cLable2.Text = "Thành tiền:";
            // 
            // fpnelTop
            // 
            this.fpnelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnelTop.Location = new System.Drawing.Point(469, 0);
            this.fpnelTop.Name = "fpnelTop";
            this.fpnelTop.Size = new System.Drawing.Size(811, 64);
            this.fpnelTop.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(469, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 635);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // frmChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 699);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.fpnelTop);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonMon";
            this.Text = "frmChonMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChonMon_Load);
            this.panel1.ResumeLayout(false);
            this.cGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOD)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CButton btnThanhToan;
        private CustomControl.ControlCustom.CButton btnGoiMon;
        private CustomControl.ControlCustom.CTextBox txtThanhTien;
        private CustomControl.ControlCustom.CLable cLable2;
        private System.Windows.Forms.FlowLayoutPanel fpnelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CDataGirdView dgvOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private CustomControl.ControlCustom.CTextBox txtBan;
        private CustomControl.ControlCustom.CLable cLable1;
    }
}