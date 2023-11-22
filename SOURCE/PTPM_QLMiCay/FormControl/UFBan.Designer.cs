namespace FormControl
{
    partial class UFBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFBan));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChinhSuaBan = new CustomControl.ControlCustom.CButton();
            this.cGroupBox1 = new CustomControl.ControlCustom.CGroupBox();
            this.panelLeft.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.cGroupBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(256, 606);
            this.panelLeft.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(256, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(852, 606);
            this.panelBody.TabIndex = 1;
            // 
            // btnChinhSuaBan
            // 
            this.btnChinhSuaBan.ActiveBorderThickness = 1;
            this.btnChinhSuaBan.ActiveCornerRadius = 20;
            this.btnChinhSuaBan.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnChinhSuaBan.ActiveForecolor = System.Drawing.Color.White;
            this.btnChinhSuaBan.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnChinhSuaBan.BackColor = System.Drawing.Color.White;
            this.btnChinhSuaBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChinhSuaBan.BackgroundImage")));
            this.btnChinhSuaBan.ButtonText = "Chỉnh sửa bàn";
            this.btnChinhSuaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSuaBan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChinhSuaBan.ForeColor = System.Drawing.Color.Orange;
            this.btnChinhSuaBan.IdleBorderThickness = 1;
            this.btnChinhSuaBan.IdleCornerRadius = 20;
            this.btnChinhSuaBan.IdleFillColor = System.Drawing.Color.White;
            this.btnChinhSuaBan.IdleForecolor = System.Drawing.Color.Orange;
            this.btnChinhSuaBan.IdleLineColor = System.Drawing.Color.Orange;
            this.btnChinhSuaBan.Location = new System.Drawing.Point(37, 30);
            this.btnChinhSuaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChinhSuaBan.Name = "btnChinhSuaBan";
            this.btnChinhSuaBan.Size = new System.Drawing.Size(163, 41);
            this.btnChinhSuaBan.TabIndex = 22;
            this.btnChinhSuaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChinhSuaBan.Click += new System.EventHandler(this.btnChinhSuaBan_Click);
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.White;
            this.cGroupBox1.Controls.Add(this.btnChinhSuaBan);
            this.cGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cGroupBox1.ForeColor = System.Drawing.Color.Orange;
            this.cGroupBox1.Location = new System.Drawing.Point(3, 5);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(253, 598);
            this.cGroupBox1.TabIndex = 0;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Chức năng";
            // 
            // UFBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelLeft);
            this.Name = "UFBan";
            this.Size = new System.Drawing.Size(1108, 606);
            this.panelLeft.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private CustomControl.ControlCustom.CButton btnChinhSuaBan;
        private System.Windows.Forms.FlowLayoutPanel panelBody;
        private CustomControl.ControlCustom.CGroupBox cGroupBox1;
    }
}
