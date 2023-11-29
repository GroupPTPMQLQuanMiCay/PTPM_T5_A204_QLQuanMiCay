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
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.cButton2 = new CustomControl.ControlCustom.CButton();
            this.cButton1 = new CustomControl.ControlCustom.CButton();
            this.cTextBox2 = new CustomControl.ControlCustom.CTextBox();
            this.cLable2 = new CustomControl.ControlCustom.CLable();
            this.fpnelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cGroupBox2 = new CustomControl.ControlCustom.CGroupBox();
            this.dgvOD = new CustomControl.ControlCustom.CDataGirdView();
            this.panel1.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOD)).BeginInit();
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
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.cButton2);
            this.cGroupBox1.Controls.Add(this.cButton1);
            this.cGroupBox1.Controls.Add(this.cTextBox2);
            this.cGroupBox1.Controls.Add(this.cLable2);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(72, 347);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(234, 238);
            this.cGroupBox1.TabIndex = 1;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Thông tin chi tiết";
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
            this.cButton2.ButtonText = "Thanh toán";
            this.cButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton2.ForeColor = System.Drawing.Color.Orange;
            this.cButton2.IdleBorderThickness = 1;
            this.cButton2.IdleCornerRadius = 20;
            this.cButton2.IdleFillColor = System.Drawing.Color.White;
            this.cButton2.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton2.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton2.Location = new System.Drawing.Point(22, 178);
            this.cButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(176, 41);
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
            this.cButton1.ButtonText = "Gọi món";
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cButton1.ForeColor = System.Drawing.Color.Orange;
            this.cButton1.IdleBorderThickness = 1;
            this.cButton1.IdleCornerRadius = 20;
            this.cButton1.IdleFillColor = System.Drawing.Color.White;
            this.cButton1.IdleForecolor = System.Drawing.Color.Orange;
            this.cButton1.IdleLineColor = System.Drawing.Color.Orange;
            this.cButton1.Location = new System.Drawing.Point(22, 127);
            this.cButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(176, 41);
            this.cButton1.TabIndex = 22;
            this.cButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cTextBox2.isPassword = false;
            this.cTextBox2.Location = new System.Drawing.Point(19, 69);
            this.cTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Size = new System.Drawing.Size(179, 33);
            this.cTextBox2.TabIndex = 6;
            this.cTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cLable2
            // 
            this.cLable2.AutoSize = true;
            this.cLable2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLable2.ForeColor = System.Drawing.Color.Orange;
            this.cLable2.Location = new System.Drawing.Point(15, 44);
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
            // cGroupBox2
            // 
            this.cGroupBox2.BackColor = System.Drawing.Color.White;
            this.cGroupBox2.Controls.Add(this.dgvOD);
            this.cGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox2.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox2.Location = new System.Drawing.Point(12, 35);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(433, 262);
            this.cGroupBox2.TabIndex = 2;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Chi tiết gọi món";
            // 
            // dgvOD
            // 
            this.dgvOD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOD.BackgroundColor = System.Drawing.Color.White;
            this.dgvOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOD.GridColor = System.Drawing.Color.White;
            this.dgvOD.Location = new System.Drawing.Point(3, 25);
            this.dgvOD.Name = "dgvOD";
            this.dgvOD.RowHeadersVisible = false;
            this.dgvOD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOD.Size = new System.Drawing.Size(427, 234);
            this.dgvOD.TabIndex = 0;
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
            this.panel1.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.cGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
        private CustomControl.ControlCustom.CButton cButton2;
        private CustomControl.ControlCustom.CButton cButton1;
        private CustomControl.ControlCustom.CTextBox cTextBox2;
        private CustomControl.ControlCustom.CLable cLable2;
        private System.Windows.Forms.FlowLayoutPanel fpnelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControl.ControlCustom.CGroupBox cGroupBox2;
        private CustomControl.ControlCustom.CDataGirdView dgvOD;
    }
}