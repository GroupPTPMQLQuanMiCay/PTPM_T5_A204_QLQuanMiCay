namespace FormControl.Forms
{
    partial class frmHoaDonNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.cboNhaCungCap = new CustomControl.ControlCustom.CCombobox();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.cLable4 = new CustomControl.ControlCustom.CLable();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.drvHDN = new CustomControl.ControlCustom.CDataGirdView();
            this.cGroupBox3 = new CustomControl.ControlCustom.CGroupBox();
            this.drvNLNhap = new CustomControl.ControlCustom.CDataGirdView();
            this.cboMaDH = new CustomControl.ControlCustom.CCombobox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.dateNgayNhap = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnSearch = new CustomControl.ControlCustom.CButton();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroupBox1.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvHDN)).BeginInit();
            this.cGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvNLNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.btnSearch);
            this.cGroupBox1.Controls.Add(this.dateNgayNhap);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Controls.Add(this.cboMaDH);
            this.cGroupBox1.Controls.Add(this.cboNhaCungCap);
            this.cGroupBox1.Controls.Add(this.cLable1);
            this.cGroupBox1.Controls.Add(this.cLable4);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(28, 99);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(758, 142);
            this.cGroupBox1.TabIndex = 18;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông tin";
            this.cGroupBox1.Enter += new System.EventHandler(this.cGroupBox1_Enter);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.ItemHeight = 23;
            this.cboNhaCungCap.Location = new System.Drawing.Point(291, 50);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(203, 29);
            this.cboNhaCungCap.TabIndex = 11;
            this.cboNhaCungCap.UseSelectable = true;
            this.cboNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cboNhaCungCap_SelectedIndexChanged);
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(287, 25);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(105, 21);
            this.cLable1.TabIndex = 10;
            this.cLable1.Text = "Nhà cung cấp";
            // 
            // cLable4
            // 
            this.cLable4.AutoSize = true;
            this.cLable4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable4.ForeColor = System.Drawing.Color.Orange;
            this.cLable4.Location = new System.Drawing.Point(28, 24);
            this.cLable4.Name = "cLable4";
            this.cLable4.Size = new System.Drawing.Size(100, 21);
            this.cLable4.TabIndex = 8;
            this.cLable4.Text = "Mã đặt hàng:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(28, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(758, 35);
            this.bunifuSeparator1.TabIndex = 17;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(21, 27);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(203, 38);
            this.cLableTitle1.TabIndex = 16;
            this.cLableTitle1.Text = "Hóa Đơn Nhập";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.drvHDN);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(31, 277);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(758, 191);
            this.cGroupBox2.TabIndex = 19;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Hóa đơn";
            // 
            // drvHDN
            // 
            this.drvHDN.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.drvHDN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.drvHDN.BackgroundColor = System.Drawing.Color.White;
            this.drvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.drvHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvHDN.GridColor = System.Drawing.Color.White;
            this.drvHDN.Location = new System.Drawing.Point(3, 25);
            this.drvHDN.Name = "drvHDN";
            this.drvHDN.RowHeadersVisible = false;
            this.drvHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvHDN.Size = new System.Drawing.Size(752, 163);
            this.drvHDN.TabIndex = 0;
            this.drvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvHDN_CellClick);
            // 
            // cGroupBox3
            // 
            this.cGroupBox3.BackColor = System.Drawing.Color.White;
            this.cGroupBox3.Controls.Add(this.drvNLNhap);
            this.cGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox3.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox3.Location = new System.Drawing.Point(28, 486);
            this.cGroupBox3.Name = "cGroupBox3";
            this.cGroupBox3.Size = new System.Drawing.Size(758, 168);
            this.cGroupBox3.TabIndex = 20;
            this.cGroupBox3.TabStop = false;
            this.cGroupBox3.Text = "Nguyên liệu nhập";
            // 
            // drvNLNhap
            // 
            this.drvNLNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            this.drvNLNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.drvNLNhap.BackgroundColor = System.Drawing.Color.White;
            this.drvNLNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvNLNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.drvNLNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvNLNhap.GridColor = System.Drawing.Color.White;
            this.drvNLNhap.Location = new System.Drawing.Point(3, 25);
            this.drvNLNhap.Name = "drvNLNhap";
            this.drvNLNhap.RowHeadersVisible = false;
            this.drvNLNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvNLNhap.Size = new System.Drawing.Size(752, 140);
            this.drvNLNhap.TabIndex = 0;
            // 
            // cboMaDH
            // 
            this.cboMaDH.FormattingEnabled = true;
            this.cboMaDH.ItemHeight = 23;
            this.cboMaDH.Location = new System.Drawing.Point(32, 50);
            this.cboMaDH.Name = "cboMaDH";
            this.cboMaDH.Size = new System.Drawing.Size(203, 29);
            this.cboMaDH.TabIndex = 12;
            this.cboMaDH.UseSelectable = true;
            this.cboMaDH.SelectedIndexChanged += new System.EventHandler(this.cboMaDH_SelectedIndexChanged);
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(540, 25);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(72, 21);
            this.cLable2.TabIndex = 13;
            this.cLable2.Text = "Ngày lập";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.BackColor = System.Drawing.Color.Orange;
            this.dateNgayNhap.BorderRadius = 0;
            this.dateNgayNhap.ForeColor = System.Drawing.Color.White;
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhap.FormatCustom = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(544, 50);
            this.dateNgayNhap.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(203, 29);
            this.dateNgayNhap.TabIndex = 14;
            this.dateNgayNhap.Value = new System.DateTime(2023, 11, 20, 17, 32, 26, 409);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm hóa đơn";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.Orange;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.Orange;
            this.btnSearch.IdleLineColor = System.Drawing.Color.Orange;
            this.btnSearch.Location = new System.Drawing.Point(544, 92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 41);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "NL_Id";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Tên NL";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "ĐVT";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Số lượng";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Đơn giá";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Thành tiền";
            this.Column11.Name = "Column11";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "HDN_Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "NV_Ten";
            this.Column2.HeaderText = "Nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "HDN_Ngaynhap";
            this.Column3.HeaderText = "Ngày đặt";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "HDN_ThanhTien";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "PD_Id";
            this.Column5.HeaderText = "Phiếu đặt ID";
            this.Column5.Name = "Column5";
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 667);
            this.Controls.Add(this.cGroupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cLableTitle1);
            this.Controls.Add(this.cGroupBox2);
            this.Controls.Add(this.cGroupBox3);
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.cGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvHDN)).EndInit();
            this.cGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvNLNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CCombobox cboNhaCungCap;
        private CustomControl.ControlCustom.CLable cLable1;
        private CustomControl.ControlCustom.CLable cLable4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CDataGirdView drvHDN;
        private CustomControl.ControlCustom.CGroupBox cGroupBox3;
        private CustomControl.ControlCustom.CDataGirdView drvNLNhap;
        private CustomControl.ControlCustom.CCombobox cboMaDH;
        private CustomControl.ControlCustom.CLable cLable2;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgayNhap;
        private CustomControl.ControlCustom.CButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}