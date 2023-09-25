namespace FormControl
{
    partial class UFNguyenLieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFNguyenLieu));
            this.cGroupBox4 = new CustomControl.ControlCustom.CGroupBox();
            this.drvNguyenLieu = new CustomControl.ControlCustom.CDataGirdView();
            this.cGroupBox3 = new CustomControl.ControlCustom.CGroupBox();
            this.txtTimTenNL = new CustomControl.ControlCustom.CTextBox();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.cButton6 = new CustomControl.ControlCustom.CButton();
            this.cButton5 = new CustomControl.ControlCustom.CButton();
            this.cButton4 = new CustomControl.ControlCustom.CButton();
            this.cButton3 = new CustomControl.ControlCustom.CButton();
            this.cButton2 = new CustomControl.ControlCustom.CButton();
            this.cButton1 = new CustomControl.ControlCustom.CButton();
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.txtDonGia = new CustomControl.ControlCustom.CTextBox();
            this.txtTenNL = new CustomControl.ControlCustom.CTextBox();
            this.cboDonViTinh = new CustomControl.ControlCustom.CCombobox();
            this.txtId = new CustomControl.ControlCustom.CTextBox();
            this.cboNhaCungCap = new CustomControl.ControlCustom.CCombobox();
            this.cLable5 = new CustomControl.ControlCustom.CLable();
            this.cLable4 = new CustomControl.ControlCustom.CLable();
            this.cLable3 = new CustomControl.ControlCustom.CLable();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvNguyenLieu)).BeginInit();
            this.cGroupBox3.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cGroupBox4
            // 
            this.cGroupBox4.BackColor = System.Drawing.Color.White;
            this.cGroupBox4.Controls.Add(this.drvNguyenLieu);
            this.cGroupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox4.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox4.Location = new System.Drawing.Point(476, 164);
            this.cGroupBox4.Name = "cGroupBox4";
            this.cGroupBox4.Size = new System.Drawing.Size(463, 414);
            this.cGroupBox4.TabIndex = 3;
            this.cGroupBox4.TabStop = false;
            this.cGroupBox4.Text = "Danh sách nguyên liệu";
            this.cGroupBox4.Enter += new System.EventHandler(this.cGroupBox4_Enter);
            // 
            // drvNguyenLieu
            // 
            this.drvNguyenLieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.drvNguyenLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.drvNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            this.drvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvNguyenLieu.GridColor = System.Drawing.Color.White;
            this.drvNguyenLieu.Location = new System.Drawing.Point(3, 25);
            this.drvNguyenLieu.Name = "drvNguyenLieu";
            this.drvNguyenLieu.RowHeadersVisible = false;
            this.drvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvNguyenLieu.Size = new System.Drawing.Size(457, 386);
            this.drvNguyenLieu.TabIndex = 0;
            this.drvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvNguyenLieu_CellClick);
            // 
            // cGroupBox3
            // 
            this.cGroupBox3.BackColor = System.Drawing.Color.White;
            this.cGroupBox3.Controls.Add(this.txtTimTenNL);
            this.cGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox3.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox3.Location = new System.Drawing.Point(476, 80);
            this.cGroupBox3.Name = "cGroupBox3";
            this.cGroupBox3.Size = new System.Drawing.Size(463, 83);
            this.cGroupBox3.TabIndex = 2;
            this.cGroupBox3.TabStop = false;
            this.cGroupBox3.Text = "Tìm kiếm nguyên liệu";
            // 
            // txtTimTenNL
            // 
            this.txtTimTenNL.BackColor = System.Drawing.Color.White;
            this.txtTimTenNL.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtTimTenNL.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtTimTenNL.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtTimTenNL.BorderThickness = 1;
            this.txtTimTenNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTenNL.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTimTenNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimTenNL.isPassword = false;
            this.txtTimTenNL.Location = new System.Drawing.Point(7, 29);
            this.txtTimTenNL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTenNL.Name = "txtTimTenNL";
            this.txtTimTenNL.Size = new System.Drawing.Size(360, 29);
            this.txtTimTenNL.TabIndex = 11;
            this.txtTimTenNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimTenNL.OnValueChanged += new System.EventHandler(this.txtTimTenNL_OnValueChanged);
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.cButton6);
            this.cGroupBox2.Controls.Add(this.cButton5);
            this.cGroupBox2.Controls.Add(this.cButton4);
            this.cGroupBox2.Controls.Add(this.cButton3);
            this.cGroupBox2.Controls.Add(this.cButton2);
            this.cGroupBox2.Controls.Add(this.cButton1);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(3, 312);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(458, 266);
            this.cGroupBox2.TabIndex = 1;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Chức năng";
            // 
            // cButton6
            // 
            this.cButton6.ActiveBorderThickness = 1;
            this.cButton6.ActiveCornerRadius = 20;
            this.cButton6.ActiveFillColor = System.Drawing.Color.Orange;
            this.cButton6.ActiveForecolor = System.Drawing.Color.White;
            this.cButton6.ActiveLineColor = System.Drawing.Color.Orange;
            this.cButton6.BackColor = System.Drawing.Color.White;
            this.cButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cButton6.BackgroundImage")));
            this.cButton6.ButtonText = "Lưu";
            this.cButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton6.ForeColor = System.Drawing.Color.Orange;
            this.cButton6.IdleBorderThickness = 1;
            this.cButton6.IdleCornerRadius = 20;
            this.cButton6.IdleFillColor = System.Drawing.Color.White;
            this.cButton6.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton6.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton6.Location = new System.Drawing.Point(242, 168);
            this.cButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton6.Name = "cButton6";
            this.cButton6.Size = new System.Drawing.Size(163, 41);
            this.cButton6.TabIndex = 24;
            this.cButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cButton5
            // 
            this.cButton5.ActiveBorderThickness = 1;
            this.cButton5.ActiveCornerRadius = 20;
            this.cButton5.ActiveFillColor = System.Drawing.Color.Orange;
            this.cButton5.ActiveForecolor = System.Drawing.Color.White;
            this.cButton5.ActiveLineColor = System.Drawing.Color.Orange;
            this.cButton5.BackColor = System.Drawing.Color.White;
            this.cButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cButton5.BackgroundImage")));
            this.cButton5.ButtonText = "Thêm";
            this.cButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton5.ForeColor = System.Drawing.Color.Orange;
            this.cButton5.IdleBorderThickness = 1;
            this.cButton5.IdleCornerRadius = 20;
            this.cButton5.IdleFillColor = System.Drawing.Color.White;
            this.cButton5.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton5.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton5.Location = new System.Drawing.Point(10, 168);
            this.cButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton5.Name = "cButton5";
            this.cButton5.Size = new System.Drawing.Size(163, 41);
            this.cButton5.TabIndex = 23;
            this.cButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cButton4
            // 
            this.cButton4.ActiveBorderThickness = 1;
            this.cButton4.ActiveCornerRadius = 20;
            this.cButton4.ActiveFillColor = System.Drawing.Color.Orange;
            this.cButton4.ActiveForecolor = System.Drawing.Color.White;
            this.cButton4.ActiveLineColor = System.Drawing.Color.Orange;
            this.cButton4.BackColor = System.Drawing.Color.White;
            this.cButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cButton4.BackgroundImage")));
            this.cButton4.ButtonText = "Lịch sử giá";
            this.cButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton4.ForeColor = System.Drawing.Color.Orange;
            this.cButton4.IdleBorderThickness = 1;
            this.cButton4.IdleCornerRadius = 20;
            this.cButton4.IdleFillColor = System.Drawing.Color.White;
            this.cButton4.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton4.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton4.Location = new System.Drawing.Point(242, 104);
            this.cButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(163, 41);
            this.cButton4.TabIndex = 22;
            this.cButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cButton3
            // 
            this.cButton3.ActiveBorderThickness = 1;
            this.cButton3.ActiveCornerRadius = 20;
            this.cButton3.ActiveFillColor = System.Drawing.Color.Orange;
            this.cButton3.ActiveForecolor = System.Drawing.Color.White;
            this.cButton3.ActiveLineColor = System.Drawing.Color.Orange;
            this.cButton3.BackColor = System.Drawing.Color.White;
            this.cButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cButton3.BackgroundImage")));
            this.cButton3.ButtonText = "Hóa đơn nhập";
            this.cButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton3.ForeColor = System.Drawing.Color.Orange;
            this.cButton3.IdleBorderThickness = 1;
            this.cButton3.IdleCornerRadius = 20;
            this.cButton3.IdleFillColor = System.Drawing.Color.White;
            this.cButton3.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton3.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton3.Location = new System.Drawing.Point(10, 104);
            this.cButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton3.Name = "cButton3";
            this.cButton3.Size = new System.Drawing.Size(163, 41);
            this.cButton3.TabIndex = 22;
            this.cButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cButton2.ButtonText = "Nhập nguyên liệu";
            this.cButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton2.ForeColor = System.Drawing.Color.Orange;
            this.cButton2.IdleBorderThickness = 1;
            this.cButton2.IdleCornerRadius = 20;
            this.cButton2.IdleFillColor = System.Drawing.Color.White;
            this.cButton2.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton2.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton2.Location = new System.Drawing.Point(242, 40);
            this.cButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(163, 41);
            this.cButton2.TabIndex = 22;
            this.cButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cButton1.ButtonText = "Đặt nguyên liệu";
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton1.ForeColor = System.Drawing.Color.Orange;
            this.cButton1.IdleBorderThickness = 1;
            this.cButton1.IdleCornerRadius = 20;
            this.cButton1.IdleFillColor = System.Drawing.Color.White;
            this.cButton1.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton1.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton1.Location = new System.Drawing.Point(10, 40);
            this.cButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(163, 41);
            this.cButton1.TabIndex = 22;
            this.cButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.txtDonGia);
            this.cGroupBox1.Controls.Add(this.txtTenNL);
            this.cGroupBox1.Controls.Add(this.cboDonViTinh);
            this.cGroupBox1.Controls.Add(this.txtId);
            this.cGroupBox1.Controls.Add(this.cboNhaCungCap);
            this.cGroupBox1.Controls.Add(this.cLable5);
            this.cGroupBox1.Controls.Add(this.cLable4);
            this.cGroupBox1.Controls.Add(this.cLable3);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Controls.Add(this.cLable1);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(3, 80);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(458, 226);
            this.cGroupBox1.TabIndex = 0;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông Tin Nguyên Liệu";
            this.cGroupBox1.Enter += new System.EventHandler(this.cGroupBox1_Enter);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtDonGia.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtDonGia.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtDonGia.BorderThickness = 1;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.isPassword = false;
            this.txtDonGia.Location = new System.Drawing.Point(242, 118);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(203, 29);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTenNL
            // 
            this.txtTenNL.BackColor = System.Drawing.Color.White;
            this.txtTenNL.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtTenNL.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtTenNL.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtTenNL.BorderThickness = 1;
            this.txtTenNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNL.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTenNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNL.isPassword = false;
            this.txtTenNL.Location = new System.Drawing.Point(242, 54);
            this.txtTenNL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(203, 29);
            this.txtTenNL.TabIndex = 7;
            this.txtTenNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.ItemHeight = 23;
            this.cboDonViTinh.Location = new System.Drawing.Point(10, 183);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(203, 29);
            this.cboDonViTinh.TabIndex = 6;
            this.cboDonViTinh.UseSelectable = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColorFocused = System.Drawing.Color.Orange;
            this.txtId.BorderColorIdle = System.Drawing.Color.Orange;
            this.txtId.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txtId.BorderThickness = 1;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.isPassword = false;
            this.txtId.Location = new System.Drawing.Point(10, 118);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(203, 29);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.ItemHeight = 23;
            this.cboNhaCungCap.Location = new System.Drawing.Point(11, 54);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(203, 29);
            this.cboNhaCungCap.TabIndex = 5;
            this.cboNhaCungCap.UseSelectable = true;
            this.cboNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cboNhaCungCap_SelectedIndexChanged);
            // 
            // cLable5
            // 
            this.cLable5.AutoSize = true;
            this.cLable5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable5.ForeColor = System.Drawing.Color.Orange;
            this.cLable5.Location = new System.Drawing.Point(238, 29);
            this.cLable5.Name = "cLable5";
            this.cLable5.Size = new System.Drawing.Size(121, 21);
            this.cLable5.TabIndex = 4;
            this.cLable5.Text = "Tên nguyên liệu:";
            // 
            // cLable4
            // 
            this.cLable4.AutoSize = true;
            this.cLable4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable4.ForeColor = System.Drawing.Color.Orange;
            this.cLable4.Location = new System.Drawing.Point(238, 93);
            this.cLable4.Name = "cLable4";
            this.cLable4.Size = new System.Drawing.Size(68, 21);
            this.cLable4.TabIndex = 3;
            this.cLable4.Text = "Đơn giá:";
            // 
            // cLable3
            // 
            this.cLable3.AutoSize = true;
            this.cLable3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable3.ForeColor = System.Drawing.Color.Orange;
            this.cLable3.Location = new System.Drawing.Point(7, 159);
            this.cLable3.Name = "cLable3";
            this.cLable3.Size = new System.Drawing.Size(90, 21);
            this.cLable3.TabIndex = 2;
            this.cLable3.Text = "Đơn vị tính:";
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(6, 93);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(28, 21);
            this.cLable2.TabIndex = 1;
            this.cLable2.Text = "ID:";
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(7, 29);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(108, 21);
            this.cLable1.TabIndex = 0;
            this.cLable1.Text = "Nhà cung cấp:";
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(7, 1);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(174, 38);
            this.cLableTitle1.TabIndex = 4;
            this.cLableTitle1.Text = "Nguyên Liệu";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(10, 40);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(929, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // UFNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cLableTitle1);
            this.Controls.Add(this.cGroupBox4);
            this.Controls.Add(this.cGroupBox3);
            this.Controls.Add(this.cGroupBox2);
            this.Controls.Add(this.cGroupBox1);
            this.Name = "UFNguyenLieu";
            this.Size = new System.Drawing.Size(956, 605);
            this.Load += new System.EventHandler(this.UFNguyenLieu_Load);
            this.cGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvNguyenLieu)).EndInit();
            this.cGroupBox3.ResumeLayout(false);
            this.cGroupBox2.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CCombobox cboDonViTinh;
        private CustomControl.ControlCustom.CTextBox txtId;
        private CustomControl.ControlCustom.CCombobox cboNhaCungCap;
        private CustomControl.ControlCustom.CLable cLable5;
        private CustomControl.ControlCustom.CLable cLable4;
        private CustomControl.ControlCustom.CLable cLable3;
        private CustomControl.ControlCustom.CLable cLable2;
        private CustomControl.ControlCustom.CLable cLable1;
        private CustomControl.ControlCustom.CTextBox txtDonGia;
        private CustomControl.ControlCustom.CTextBox txtTenNL;
        private CustomControl.ControlCustom.CButton cButton3;
        private CustomControl.ControlCustom.CButton cButton2;
        private CustomControl.ControlCustom.CButton cButton1;
        private CustomControl.ControlCustom.CButton cButton6;
        private CustomControl.ControlCustom.CButton cButton5;
        private CustomControl.ControlCustom.CButton cButton4;
        private CustomControl.ControlCustom.CGroupBox cGroupBox3;
        private CustomControl.ControlCustom.CGroupBox cGroupBox4;
        private CustomControl.ControlCustom.CTextBox txtTimTenNL;
        private CustomControl.ControlCustom.CDataGirdView drvNguyenLieu;
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
