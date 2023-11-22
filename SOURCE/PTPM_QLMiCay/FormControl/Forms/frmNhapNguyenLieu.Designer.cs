namespace FormControl.Forms
{
    partial class frmNhapNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapNguyenLieu));
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.cLable6 = new CustomControl.ControlCustom.CLable();
            this.txtNhaCC = new CustomControl.ControlCustom.CTextBox();
            this.cLable5 = new CustomControl.ControlCustom.CLable();
            this.cboMaDH = new CustomControl.ControlCustom.CCombobox();
            this.cLable3 = new CustomControl.ControlCustom.CLable();
            this.txtNhanVien = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.drvNLNhap = new CustomControl.ControlCustom.CDataGirdView();
            this.btnThem = new CustomControl.ControlCustom.CButton();
            this.txtThanhTien = new CustomControl.ControlCustom.CTextBox();
            this.cLable4 = new CustomControl.ControlCustom.CLable();
            this.cGroupBox3 = new CustomControl.ControlCustom.CGroupBox();
            this.dateNgayNhap = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroupBox4 = new CustomControl.ControlCustom.CGroupBox();
            this.btnUpdate = new CustomControl.ControlCustom.CButton();
            this.txtSL = new CustomControl.ControlCustom.CNumericTextbox();
            this.cLable7 = new CustomControl.ControlCustom.CLable();
            this.cGroupBox1.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvNLNhap)).BeginInit();
            this.cGroupBox3.SuspendLayout();
            this.cGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(12, 9);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(249, 38);
            this.cLableTitle1.TabIndex = 17;
            this.cLableTitle1.Text = "Nhập Nguyên Liệu";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.txtSL);
            this.cGroupBox1.Controls.Add(this.cLable7);
            this.cGroupBox1.Controls.Add(this.dateNgayNhap);
            this.cGroupBox1.Controls.Add(this.cLable6);
            this.cGroupBox1.Controls.Add(this.txtNhaCC);
            this.cGroupBox1.Controls.Add(this.cLable5);
            this.cGroupBox1.Controls.Add(this.cboMaDH);
            this.cGroupBox1.Controls.Add(this.cLable3);
            this.cGroupBox1.Controls.Add(this.txtNhanVien);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(19, 81);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(467, 253);
            this.cGroupBox1.TabIndex = 16;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông tin nhập";
            // 
            // cLable6
            // 
            this.cLable6.AutoSize = true;
            this.cLable6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable6.ForeColor = System.Drawing.Color.Orange;
            this.cLable6.Location = new System.Drawing.Point(234, 108);
            this.cLable6.Name = "cLable6";
            this.cLable6.Size = new System.Drawing.Size(108, 21);
            this.cLable6.TabIndex = 10;
            this.cLable6.Text = "Nhà cung cấp:";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.BackColor = System.Drawing.Color.White;
            this.txtNhaCC.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtNhaCC.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtNhaCC.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtNhaCC.BorderThickness = 1;
            this.txtNhaCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCC.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNhaCC.isPassword = false;
            this.txtNhaCC.Location = new System.Drawing.Point(238, 133);
            this.txtNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(203, 29);
            this.txtNhaCC.TabIndex = 5;
            this.txtNhaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable5
            // 
            this.cLable5.AutoSize = true;
            this.cLable5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable5.ForeColor = System.Drawing.Color.Orange;
            this.cLable5.Location = new System.Drawing.Point(5, 39);
            this.cLable5.Name = "cLable5";
            this.cLable5.Size = new System.Drawing.Size(100, 21);
            this.cLable5.TabIndex = 9;
            this.cLable5.Text = "Mã đặt hàng:";
            // 
            // cboMaDH
            // 
            this.cboMaDH.FormattingEnabled = true;
            this.cboMaDH.ItemHeight = 23;
            this.cboMaDH.Location = new System.Drawing.Point(9, 63);
            this.cboMaDH.Name = "cboMaDH";
            this.cboMaDH.Size = new System.Drawing.Size(203, 29);
            this.cboMaDH.TabIndex = 7;
            this.cboMaDH.UseSelectable = true;
            this.cboMaDH.SelectedIndexChanged += new System.EventHandler(this.cboMaDH_SelectedIndexChanged);
            // 
            // cLable3
            // 
            this.cLable3.AutoSize = true;
            this.cLable3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable3.ForeColor = System.Drawing.Color.Orange;
            this.cLable3.Location = new System.Drawing.Point(7, 179);
            this.cLable3.Name = "cLable3";
            this.cLable3.Size = new System.Drawing.Size(89, 21);
            this.cLable3.TabIndex = 4;
            this.cLable3.Text = "Ngày nhập:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.Color.White;
            this.txtNhanVien.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtNhanVien.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtNhanVien.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtNhanVien.BorderThickness = 1;
            this.txtNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanVien.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNhanVien.isPassword = false;
            this.txtNhanVien.Location = new System.Drawing.Point(7, 133);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(203, 29);
            this.txtNhanVien.TabIndex = 1;
            this.txtNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(7, 108);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(84, 21);
            this.cLable2.TabIndex = 2;
            this.cLable2.Text = "Nhân viên:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(19, 51);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1324, 35);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.drvNLNhap);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(492, 81);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(851, 352);
            this.cGroupBox2.TabIndex = 20;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Thông tin";
            // 
            // drvNLNhap
            // 
            this.drvNLNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            this.drvNLNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.drvNLNhap.BackgroundColor = System.Drawing.Color.White;
            this.drvNLNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvNLNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column7});
            this.drvNLNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvNLNhap.GridColor = System.Drawing.Color.White;
            this.drvNLNhap.Location = new System.Drawing.Point(3, 25);
            this.drvNLNhap.Name = "drvNLNhap";
            this.drvNLNhap.RowHeadersVisible = false;
            this.drvNLNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvNLNhap.Size = new System.Drawing.Size(845, 324);
            this.drvNLNhap.TabIndex = 0;
            this.drvNLNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvNLNhap_CellClick);
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
            this.btnThem.ButtonText = "Nhập nguyên liệu";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.Orange;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.White;
            this.btnThem.IdleForecolor = System.Drawing.Color.Orange;
            this.btnThem.IdleLineColor = System.Drawing.Color.Orange;
            this.btnThem.Location = new System.Drawing.Point(24, 40);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 41);
            this.btnThem.TabIndex = 25;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtThanhTien.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtThanhTien.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtThanhTien.BorderThickness = 1;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThanhTien.isPassword = false;
            this.txtThanhTien.Location = new System.Drawing.Point(1023, 52);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(203, 29);
            this.txtThanhTien.TabIndex = 24;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable4
            // 
            this.cLable4.AutoSize = true;
            this.cLable4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable4.ForeColor = System.Drawing.Color.Orange;
            this.cLable4.Location = new System.Drawing.Point(1018, 27);
            this.cLable4.Name = "cLable4";
            this.cLable4.Size = new System.Drawing.Size(89, 21);
            this.cLable4.TabIndex = 26;
            this.cLable4.Text = "Thành Tiền:";
            // 
            // cGroupBox3
            // 
            this.cGroupBox3.BackColor = System.Drawing.Color.White;
            this.cGroupBox3.Controls.Add(this.txtThanhTien);
            this.cGroupBox3.Controls.Add(this.btnThem);
            this.cGroupBox3.Controls.Add(this.cLable4);
            this.cGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox3.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox3.Location = new System.Drawing.Point(19, 455);
            this.cGroupBox3.Name = "cGroupBox3";
            this.cGroupBox3.Size = new System.Drawing.Size(1257, 109);
            this.cGroupBox3.TabIndex = 21;
            this.cGroupBox3.TabStop = false;
            this.cGroupBox3.Text = "Chức năng";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.BackColor = System.Drawing.Color.Orange;
            this.dateNgayNhap.BorderRadius = 0;
            this.dateNgayNhap.ForeColor = System.Drawing.Color.White;
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhap.FormatCustom = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(9, 208);
            this.dateNgayNhap.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(201, 34);
            this.dateNgayNhap.TabIndex = 11;
            this.dateNgayNhap.Value = new System.DateTime(2023, 11, 20, 17, 32, 26, 409);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "NL_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên nguyên liệu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Số lượng cần giao";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Số lượng thực";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.Name = "Column7";
            // 
            // cGroupBox4
            // 
            this.cGroupBox4.BackColor = System.Drawing.Color.White;
            this.cGroupBox4.Controls.Add(this.btnUpdate);
            this.cGroupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox4.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox4.Location = new System.Drawing.Point(19, 350);
            this.cGroupBox4.Name = "cGroupBox4";
            this.cGroupBox4.Size = new System.Drawing.Size(467, 83);
            this.cGroupBox4.TabIndex = 22;
            this.cGroupBox4.TabStop = false;
            this.cGroupBox4.Text = "Chức năng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Cập nhật phiếu nhập";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Orange;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.Orange;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.Orange;
            this.btnUpdate.Location = new System.Drawing.Point(153, 30);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 41);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.White;
            this.txtSL.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtSL.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtSL.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtSL.BorderThickness = 1;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSL.isPassword = false;
            this.txtSL.Location = new System.Drawing.Point(239, 213);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(204, 29);
            this.txtSL.TabIndex = 12;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable7
            // 
            this.cLable7.AutoSize = true;
            this.cLable7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable7.ForeColor = System.Drawing.Color.Orange;
            this.cLable7.Location = new System.Drawing.Point(243, 188);
            this.cLable7.Name = "cLable7";
            this.cLable7.Size = new System.Drawing.Size(73, 21);
            this.cLable7.TabIndex = 13;
            this.cLable7.Text = "Số lượng";
            // 
            // frmNhapNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 623);
            this.Controls.Add(this.cGroupBox4);
            this.Controls.Add(this.cLableTitle1);
            this.Controls.Add(this.cGroupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cGroupBox2);
            this.Controls.Add(this.cGroupBox3);
            this.Name = "frmNhapNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapNguyenLieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapNguyenLieu_Load);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.cGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvNLNhap)).EndInit();
            this.cGroupBox3.ResumeLayout(false);
            this.cGroupBox3.PerformLayout();
            this.cGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CLable cLable6;
        private CustomControl.ControlCustom.CTextBox txtNhaCC;
        private CustomControl.ControlCustom.CLable cLable5;
        private CustomControl.ControlCustom.CCombobox cboMaDH;
        private CustomControl.ControlCustom.CLable cLable3;
        private CustomControl.ControlCustom.CTextBox txtNhanVien;
        private CustomControl.ControlCustom.CLable cLable2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CDataGirdView drvNLNhap;
        private CustomControl.ControlCustom.CButton btnThem;
        private CustomControl.ControlCustom.CTextBox txtThanhTien;
        private CustomControl.ControlCustom.CLable cLable4;
        private CustomControl.ControlCustom.CGroupBox cGroupBox3;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private CustomControl.ControlCustom.CGroupBox cGroupBox4;
        private CustomControl.ControlCustom.CButton btnUpdate;
        private CustomControl.ControlCustom.CNumericTextbox txtSL;
        private CustomControl.ControlCustom.CLable cLable7;
    }
}