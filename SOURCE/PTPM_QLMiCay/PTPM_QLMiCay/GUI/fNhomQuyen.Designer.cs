namespace PTPM_QLMiCay.GUI
{
    partial class fNhomQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhomQuyen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cLableTitle1 = new CustomControl.ControlCustom.CLableTitle();
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.txt_HienThi = new CustomControl.ControlCustom.CTextBox();
            this.cLable5 = new CustomControl.ControlCustom.CLable();
            this.cbb_NQ = new CustomControl.ControlCustom.CCombobox();
            this.txt_TenNQ = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.txt_NQID = new CustomControl.ControlCustom.CTextBox();
            this.cLable1 = new CustomControl.ControlCustom.CLable();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.btn_GanQuyen = new CustomControl.ControlCustom.CButton();
            this.btn_SuaNQ = new CustomControl.ControlCustom.CButton();
            this.btn_XoaNQ = new CustomControl.ControlCustom.CButton();
            this.btn_ThemNQ = new CustomControl.ControlCustom.CButton();
            this.cGroupBox3 = new CustomControl.ControlCustom.CGroupBox();
            this.dgv_Quyen = new CustomControl.ControlCustom.CDataGirdView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cGroupBox1.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            this.cGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quyen)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(9, 41);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(956, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // cLableTitle1
            // 
            this.cLableTitle1.AutoSize = true;
            this.cLableTitle1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.cLableTitle1.ForeColor = System.Drawing.Color.Orange;
            this.cLableTitle1.Location = new System.Drawing.Point(2, -1);
            this.cLableTitle1.Name = "cLableTitle1";
            this.cLableTitle1.Size = new System.Drawing.Size(184, 38);
            this.cLableTitle1.TabIndex = 4;
            this.cLableTitle1.Text = "Nhóm Quyền";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.txt_HienThi);
            this.cGroupBox1.Controls.Add(this.cLable5);
            this.cGroupBox1.Controls.Add(this.cbb_NQ);
            this.cGroupBox1.Controls.Add(this.txt_TenNQ);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Controls.Add(this.txt_NQID);
            this.cGroupBox1.Controls.Add(this.cLable1);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(9, 70);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(445, 183);
            this.cGroupBox1.TabIndex = 6;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông tin nhóm quyền";
            // 
            // txt_HienThi
            // 
            this.txt_HienThi.BackColor = System.Drawing.Color.White;
            this.txt_HienThi.BorderColorFocused = System.Drawing.Color.Orange;
            this.txt_HienThi.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_HienThi.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txt_HienThi.BorderThickness = 1;
            this.txt_HienThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HienThi.Enabled = false;
            this.txt_HienThi.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_HienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_HienThi.isPassword = false;
            this.txt_HienThi.Location = new System.Drawing.Point(238, 63);
            this.txt_HienThi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HienThi.Name = "txt_HienThi";
            this.txt_HienThi.Size = new System.Drawing.Size(203, 29);
            this.txt_HienThi.TabIndex = 5;
            this.txt_HienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable5
            // 
            this.cLable5.AutoSize = true;
            this.cLable5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable5.ForeColor = System.Drawing.Color.Orange;
            this.cLable5.Location = new System.Drawing.Point(234, 39);
            this.cLable5.Name = "cLable5";
            this.cLable5.Size = new System.Drawing.Size(67, 21);
            this.cLable5.TabIndex = 9;
            this.cLable5.Text = "Hiển thị:";
            // 
            // cbb_NQ
            // 
            this.cbb_NQ.FormattingEnabled = true;
            this.cbb_NQ.ItemHeight = 23;
            this.cbb_NQ.Location = new System.Drawing.Point(238, 133);
            this.cbb_NQ.Name = "cbb_NQ";
            this.cbb_NQ.Size = new System.Drawing.Size(203, 29);
            this.cbb_NQ.TabIndex = 7;
            this.cbb_NQ.UseSelectable = true;
            this.cbb_NQ.SelectedIndexChanged += new System.EventHandler(this.cbb_NQ_SelectedIndexChanged);
            // 
            // txt_TenNQ
            // 
            this.txt_TenNQ.BackColor = System.Drawing.Color.White;
            this.txt_TenNQ.BorderColorFocused = System.Drawing.Color.Orange;
            this.txt_TenNQ.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_TenNQ.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txt_TenNQ.BorderThickness = 1;
            this.txt_TenNQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenNQ.Enabled = false;
            this.txt_TenNQ.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_TenNQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TenNQ.isPassword = false;
            this.txt_TenNQ.Location = new System.Drawing.Point(7, 133);
            this.txt_TenNQ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNQ.Name = "txt_TenNQ";
            this.txt_TenNQ.Size = new System.Drawing.Size(203, 29);
            this.txt_TenNQ.TabIndex = 1;
            this.txt_TenNQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(7, 108);
            this.cLable2.Name = "cLable2";
            this.cLable2.Size = new System.Drawing.Size(128, 21);
            this.cLable2.TabIndex = 2;
            this.cLable2.Text = "Tên nhóm quyền:";
            // 
            // txt_NQID
            // 
            this.txt_NQID.BackColor = System.Drawing.Color.White;
            this.txt_NQID.BorderColorFocused = System.Drawing.Color.Orange;
            this.txt_NQID.BorderColorIdle = System.Drawing.Color.Orange;
            this.txt_NQID.BorderColorMouseHover = System.Drawing.Color.Orange;
            this.txt_NQID.BorderThickness = 1;
            this.txt_NQID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NQID.Enabled = false;
            this.txt_NQID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_NQID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NQID.isPassword = false;
            this.txt_NQID.Location = new System.Drawing.Point(7, 63);
            this.txt_NQID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NQID.Name = "txt_NQID";
            this.txt_NQID.Size = new System.Drawing.Size(203, 29);
            this.txt_NQID.TabIndex = 0;
            this.txt_NQID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable1
            // 
            this.cLable1.AutoSize = true;
            this.cLable1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable1.ForeColor = System.Drawing.Color.Orange;
            this.cLable1.Location = new System.Drawing.Point(7, 38);
            this.cLable1.Name = "cLable1";
            this.cLable1.Size = new System.Drawing.Size(123, 21);
            this.cLable1.TabIndex = 0;
            this.cLable1.Text = "Nhóm quyền ID:";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.btn_GanQuyen);
            this.cGroupBox2.Controls.Add(this.btn_SuaNQ);
            this.cGroupBox2.Controls.Add(this.btn_XoaNQ);
            this.cGroupBox2.Controls.Add(this.btn_ThemNQ);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(9, 259);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(445, 182);
            this.cGroupBox2.TabIndex = 7;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Chức năng";
            // 
            // btn_GanQuyen
            // 
            this.btn_GanQuyen.ActiveBorderThickness = 1;
            this.btn_GanQuyen.ActiveCornerRadius = 20;
            this.btn_GanQuyen.ActiveFillColor = System.Drawing.Color.Orange;
            this.btn_GanQuyen.ActiveForecolor = System.Drawing.Color.White;
            this.btn_GanQuyen.ActiveLineColor = System.Drawing.Color.Orange;
            this.btn_GanQuyen.BackColor = System.Drawing.Color.White;
            this.btn_GanQuyen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GanQuyen.BackgroundImage")));
            this.btn_GanQuyen.ButtonText = "Gán quyền";
            this.btn_GanQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GanQuyen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_GanQuyen.ForeColor = System.Drawing.Color.Orange;
            this.btn_GanQuyen.IdleBorderThickness = 1;
            this.btn_GanQuyen.IdleCornerRadius = 20;
            this.btn_GanQuyen.IdleFillColor = System.Drawing.Color.White;
            this.btn_GanQuyen.IdleForecolor = System.Drawing.Color.Orange;
            this.btn_GanQuyen.IdleLineColor = System.Drawing.Color.Orange;
            this.btn_GanQuyen.Location = new System.Drawing.Point(254, 117);
            this.btn_GanQuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GanQuyen.Name = "btn_GanQuyen";
            this.btn_GanQuyen.Size = new System.Drawing.Size(163, 41);
            this.btn_GanQuyen.TabIndex = 25;
            this.btn_GanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_GanQuyen.Click += new System.EventHandler(this.btn_GanQuyen_Click);
            // 
            // btn_SuaNQ
            // 
            this.btn_SuaNQ.ActiveBorderThickness = 1;
            this.btn_SuaNQ.ActiveCornerRadius = 20;
            this.btn_SuaNQ.ActiveFillColor = System.Drawing.Color.Orange;
            this.btn_SuaNQ.ActiveForecolor = System.Drawing.Color.White;
            this.btn_SuaNQ.ActiveLineColor = System.Drawing.Color.Orange;
            this.btn_SuaNQ.BackColor = System.Drawing.Color.White;
            this.btn_SuaNQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SuaNQ.BackgroundImage")));
            this.btn_SuaNQ.ButtonText = "Sửa";
            this.btn_SuaNQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SuaNQ.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SuaNQ.ForeColor = System.Drawing.Color.Orange;
            this.btn_SuaNQ.IdleBorderThickness = 1;
            this.btn_SuaNQ.IdleCornerRadius = 20;
            this.btn_SuaNQ.IdleFillColor = System.Drawing.Color.White;
            this.btn_SuaNQ.IdleForecolor = System.Drawing.Color.Orange;
            this.btn_SuaNQ.IdleLineColor = System.Drawing.Color.Orange;
            this.btn_SuaNQ.Location = new System.Drawing.Point(11, 117);
            this.btn_SuaNQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SuaNQ.Name = "btn_SuaNQ";
            this.btn_SuaNQ.Size = new System.Drawing.Size(163, 41);
            this.btn_SuaNQ.TabIndex = 24;
            this.btn_SuaNQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SuaNQ.Click += new System.EventHandler(this.btn_SuaNQ_Click);
            // 
            // btn_XoaNQ
            // 
            this.btn_XoaNQ.ActiveBorderThickness = 1;
            this.btn_XoaNQ.ActiveCornerRadius = 20;
            this.btn_XoaNQ.ActiveFillColor = System.Drawing.Color.Orange;
            this.btn_XoaNQ.ActiveForecolor = System.Drawing.Color.White;
            this.btn_XoaNQ.ActiveLineColor = System.Drawing.Color.Orange;
            this.btn_XoaNQ.BackColor = System.Drawing.Color.White;
            this.btn_XoaNQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_XoaNQ.BackgroundImage")));
            this.btn_XoaNQ.ButtonText = "Xóa";
            this.btn_XoaNQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaNQ.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_XoaNQ.ForeColor = System.Drawing.Color.Orange;
            this.btn_XoaNQ.IdleBorderThickness = 1;
            this.btn_XoaNQ.IdleCornerRadius = 20;
            this.btn_XoaNQ.IdleFillColor = System.Drawing.Color.White;
            this.btn_XoaNQ.IdleForecolor = System.Drawing.Color.Orange;
            this.btn_XoaNQ.IdleLineColor = System.Drawing.Color.Orange;
            this.btn_XoaNQ.Location = new System.Drawing.Point(254, 41);
            this.btn_XoaNQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XoaNQ.Name = "btn_XoaNQ";
            this.btn_XoaNQ.Size = new System.Drawing.Size(163, 41);
            this.btn_XoaNQ.TabIndex = 23;
            this.btn_XoaNQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_XoaNQ.Click += new System.EventHandler(this.btn_XoaNQ_Click);
            // 
            // btn_ThemNQ
            // 
            this.btn_ThemNQ.ActiveBorderThickness = 1;
            this.btn_ThemNQ.ActiveCornerRadius = 20;
            this.btn_ThemNQ.ActiveFillColor = System.Drawing.Color.Orange;
            this.btn_ThemNQ.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ThemNQ.ActiveLineColor = System.Drawing.Color.Orange;
            this.btn_ThemNQ.BackColor = System.Drawing.Color.White;
            this.btn_ThemNQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThemNQ.BackgroundImage")));
            this.btn_ThemNQ.ButtonText = "Thêm";
            this.btn_ThemNQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemNQ.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ThemNQ.ForeColor = System.Drawing.Color.Orange;
            this.btn_ThemNQ.IdleBorderThickness = 1;
            this.btn_ThemNQ.IdleCornerRadius = 20;
            this.btn_ThemNQ.IdleFillColor = System.Drawing.Color.White;
            this.btn_ThemNQ.IdleForecolor = System.Drawing.Color.Orange;
            this.btn_ThemNQ.IdleLineColor = System.Drawing.Color.Orange;
            this.btn_ThemNQ.Location = new System.Drawing.Point(11, 41);
            this.btn_ThemNQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ThemNQ.Name = "btn_ThemNQ";
            this.btn_ThemNQ.Size = new System.Drawing.Size(163, 41);
            this.btn_ThemNQ.TabIndex = 22;
            this.btn_ThemNQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ThemNQ.Click += new System.EventHandler(this.btn_ThemNQ_Click);
            // 
            // cGroupBox3
            // 
            this.cGroupBox3.BackColor = System.Drawing.Color.White;
            this.cGroupBox3.Controls.Add(this.dgv_Quyen);
            this.cGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox3.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox3.Location = new System.Drawing.Point(460, 70);
            this.cGroupBox3.Name = "cGroupBox3";
            this.cGroupBox3.Size = new System.Drawing.Size(505, 371);
            this.cGroupBox3.TabIndex = 8;
            this.cGroupBox3.TabStop = false;
            this.cGroupBox3.Text = "Danh sách";
            // 
            // dgv_Quyen
            // 
            this.dgv_Quyen.AllowUserToAddRows = false;
            this.dgv_Quyen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgv_Quyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Quyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Quyen.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Quyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Quyen.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Quyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Quyen.GridColor = System.Drawing.Color.White;
            this.dgv_Quyen.Location = new System.Drawing.Point(3, 25);
            this.dgv_Quyen.Name = "dgv_Quyen";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Quyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Quyen.RowHeadersVisible = false;
            this.dgv_Quyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Quyen.Size = new System.Drawing.Size(499, 343);
            this.dgv_Quyen.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Bảng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = false;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Xem";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = false;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Thêm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = false;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Xóa";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = false;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Sửa";
            this.Column5.Name = "Column5";
            // 
            // fNhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 453);
            this.Controls.Add(this.cGroupBox3);
            this.Controls.Add(this.cGroupBox2);
            this.Controls.Add(this.cGroupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cLableTitle1);
            this.Name = "fNhomQuyen";
            this.Text = "fNhomQuyen";
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.cGroupBox2.ResumeLayout(false);
            this.cGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CustomControl.ControlCustom.CLableTitle cLableTitle1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CTextBox txt_HienThi;
        private CustomControl.ControlCustom.CLable cLable5;
        private CustomControl.ControlCustom.CCombobox cbb_NQ;
        private CustomControl.ControlCustom.CTextBox txt_TenNQ;
        private CustomControl.ControlCustom.CLable cLable2;
        private CustomControl.ControlCustom.CTextBox txt_NQID;
        private CustomControl.ControlCustom.CLable cLable1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CButton btn_GanQuyen;
        private CustomControl.ControlCustom.CButton btn_SuaNQ;
        private CustomControl.ControlCustom.CButton btn_XoaNQ;
        private CustomControl.ControlCustom.CButton btn_ThemNQ;
        private CustomControl.ControlCustom.CGroupBox cGroupBox3;
        private CustomControl.ControlCustom.CDataGirdView dgv_Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}