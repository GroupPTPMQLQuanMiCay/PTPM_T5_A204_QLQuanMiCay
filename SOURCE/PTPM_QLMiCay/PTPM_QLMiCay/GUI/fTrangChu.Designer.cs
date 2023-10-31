

namespace PTPM_QLMiCay.GUI
{
    partial class fTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string connectionString = Properties.Settings.Default.HoangConnection;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTrangChu));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnThoat = new CustomControl.ControlCustom.CButtonFlat();
            this.fDoanhThu = new CustomControl.ControlCustom.CButtonFlat();
            this.fQuyen = new CustomControl.ControlCustom.CButtonFlat();
            this.fHoaDon = new CustomControl.ControlCustom.CButtonFlat();
            this.fBan = new CustomControl.ControlCustom.CButtonFlat();
            this.fNhanVien = new CustomControl.ControlCustom.CButtonFlat();
            this.fDanhMuc = new CustomControl.ControlCustom.CButtonFlat();
            this.fNhaCungCap = new CustomControl.ControlCustom.CButtonFlat();
            this.fNguyenLieu = new CustomControl.ControlCustom.CButtonFlat();
            this.cButtonFlat1 = new CustomControl.ControlCustom.CButtonFlat();
            this.ufNhanVIen1 = new FormControl.UFNhanVIen();
            this.ufDanhMuc1 = new FormControl.UFDanhMuc();
            this.ufNhaCungCap1 = new FormControl.UFNhaCungCap();
            this.ufTrangChu1 = new FormControl.UFTrangChu();
            this.ufQuyen1 = new FormControl.UFQuyen();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnThoat);
            this.bunifuGradientPanel2.Controls.Add(this.fDoanhThu);
            this.bunifuGradientPanel2.Controls.Add(this.fQuyen);
            this.bunifuGradientPanel2.Controls.Add(this.fHoaDon);
            this.bunifuGradientPanel2.Controls.Add(this.fBan);
            this.bunifuGradientPanel2.Controls.Add(this.fNhanVien);
            this.bunifuGradientPanel2.Controls.Add(this.fDanhMuc);
            this.bunifuGradientPanel2.Controls.Add(this.fNhaCungCap);
            this.bunifuGradientPanel2.Controls.Add(this.fNguyenLieu);
            this.bunifuGradientPanel2.Controls.Add(this.cButtonFlat1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(168, 597);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Activecolor = System.Drawing.Color.Orange;
            this.btnThoat.BackColor = System.Drawing.Color.Orange;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.BorderRadius = 0;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DisabledColor = System.Drawing.Color.Gray;
            this.btnThoat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThoat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThoat.Iconimage")));
            this.btnThoat.Iconimage_right = null;
            this.btnThoat.Iconimage_right_Selected = null;
            this.btnThoat.Iconimage_Selected = null;
            this.btnThoat.IconMarginLeft = 0;
            this.btnThoat.IconMarginRight = 0;
            this.btnThoat.IconRightVisible = true;
            this.btnThoat.IconRightZoom = 0D;
            this.btnThoat.IconVisible = true;
            this.btnThoat.IconZoom = 90D;
            this.btnThoat.IsTab = false;
            this.btnThoat.Location = new System.Drawing.Point(0, 525);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Normalcolor = System.Drawing.Color.Orange;
            this.btnThoat.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThoat.selected = false;
            this.btnThoat.Size = new System.Drawing.Size(185, 48);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Textcolor = System.Drawing.Color.Black;
            this.btnThoat.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fDoanhThu
            // 
            this.fDoanhThu.Activecolor = System.Drawing.Color.Orange;
            this.fDoanhThu.BackColor = System.Drawing.Color.Orange;
            this.fDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fDoanhThu.BorderRadius = 0;
            this.fDoanhThu.ButtonText = "Doanh Thu";
            this.fDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fDoanhThu.DisabledColor = System.Drawing.Color.Gray;
            this.fDoanhThu.Iconcolor = System.Drawing.Color.Transparent;
            this.fDoanhThu.Iconimage = ((System.Drawing.Image)(resources.GetObject("fDoanhThu.Iconimage")));
            this.fDoanhThu.Iconimage_right = null;
            this.fDoanhThu.Iconimage_right_Selected = null;
            this.fDoanhThu.Iconimage_Selected = null;
            this.fDoanhThu.IconMarginLeft = 0;
            this.fDoanhThu.IconMarginRight = 0;
            this.fDoanhThu.IconRightVisible = true;
            this.fDoanhThu.IconRightZoom = 0D;
            this.fDoanhThu.IconVisible = true;
            this.fDoanhThu.IconZoom = 90D;
            this.fDoanhThu.IsTab = false;
            this.fDoanhThu.Location = new System.Drawing.Point(4, 471);
            this.fDoanhThu.Name = "fDoanhThu";
            this.fDoanhThu.Normalcolor = System.Drawing.Color.Orange;
            this.fDoanhThu.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fDoanhThu.OnHoverTextColor = System.Drawing.Color.White;
            this.fDoanhThu.selected = false;
            this.fDoanhThu.Size = new System.Drawing.Size(195, 48);
            this.fDoanhThu.TabIndex = 8;
            this.fDoanhThu.Text = "Doanh Thu";
            this.fDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fDoanhThu.Textcolor = System.Drawing.Color.Black;
            this.fDoanhThu.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // fQuyen
            // 
            this.fQuyen.Activecolor = System.Drawing.Color.Orange;
            this.fQuyen.BackColor = System.Drawing.Color.Orange;
            this.fQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fQuyen.BorderRadius = 0;
            this.fQuyen.ButtonText = "Quyền";
            this.fQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fQuyen.DisabledColor = System.Drawing.Color.Gray;
            this.fQuyen.Iconcolor = System.Drawing.Color.Transparent;
            this.fQuyen.Iconimage = ((System.Drawing.Image)(resources.GetObject("fQuyen.Iconimage")));
            this.fQuyen.Iconimage_right = null;
            this.fQuyen.Iconimage_right_Selected = null;
            this.fQuyen.Iconimage_Selected = null;
            this.fQuyen.IconMarginLeft = 0;
            this.fQuyen.IconMarginRight = 0;
            this.fQuyen.IconRightVisible = true;
            this.fQuyen.IconRightZoom = 0D;
            this.fQuyen.IconVisible = true;
            this.fQuyen.IconZoom = 90D;
            this.fQuyen.IsTab = false;
            this.fQuyen.Location = new System.Drawing.Point(4, 416);
            this.fQuyen.Name = "fQuyen";
            this.fQuyen.Normalcolor = System.Drawing.Color.Orange;
            this.fQuyen.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fQuyen.OnHoverTextColor = System.Drawing.Color.White;
            this.fQuyen.selected = false;
            this.fQuyen.Size = new System.Drawing.Size(195, 48);
            this.fQuyen.TabIndex = 7;
            this.fQuyen.Text = "Quyền";
            this.fQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fQuyen.Textcolor = System.Drawing.Color.Black;
            this.fQuyen.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.fQuyen.Click += new System.EventHandler(this.cButtonFlat8_Click);
            // 
            // fHoaDon
            // 
            this.fHoaDon.Activecolor = System.Drawing.Color.Orange;
            this.fHoaDon.BackColor = System.Drawing.Color.Orange;
            this.fHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fHoaDon.BorderRadius = 0;
            this.fHoaDon.ButtonText = "Hóa Đơn";
            this.fHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fHoaDon.DisabledColor = System.Drawing.Color.Gray;
            this.fHoaDon.Iconcolor = System.Drawing.Color.Transparent;
            this.fHoaDon.Iconimage = ((System.Drawing.Image)(resources.GetObject("fHoaDon.Iconimage")));
            this.fHoaDon.Iconimage_right = null;
            this.fHoaDon.Iconimage_right_Selected = null;
            this.fHoaDon.Iconimage_Selected = null;
            this.fHoaDon.IconMarginLeft = 0;
            this.fHoaDon.IconMarginRight = 0;
            this.fHoaDon.IconRightVisible = true;
            this.fHoaDon.IconRightZoom = 0D;
            this.fHoaDon.IconVisible = true;
            this.fHoaDon.IconZoom = 90D;
            this.fHoaDon.IsTab = false;
            this.fHoaDon.Location = new System.Drawing.Point(0, 361);
            this.fHoaDon.Name = "fHoaDon";
            this.fHoaDon.Normalcolor = System.Drawing.Color.Orange;
            this.fHoaDon.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fHoaDon.OnHoverTextColor = System.Drawing.Color.White;
            this.fHoaDon.selected = false;
            this.fHoaDon.Size = new System.Drawing.Size(199, 48);
            this.fHoaDon.TabIndex = 6;
            this.fHoaDon.Text = "Hóa Đơn";
            this.fHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fHoaDon.Textcolor = System.Drawing.Color.Black;
            this.fHoaDon.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // fBan
            // 
            this.fBan.Activecolor = System.Drawing.Color.Orange;
            this.fBan.BackColor = System.Drawing.Color.Orange;
            this.fBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fBan.BorderRadius = 0;
            this.fBan.ButtonText = "Bàn";
            this.fBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fBan.DisabledColor = System.Drawing.Color.Gray;
            this.fBan.Iconcolor = System.Drawing.Color.Transparent;
            this.fBan.Iconimage = ((System.Drawing.Image)(resources.GetObject("fBan.Iconimage")));
            this.fBan.Iconimage_right = null;
            this.fBan.Iconimage_right_Selected = null;
            this.fBan.Iconimage_Selected = null;
            this.fBan.IconMarginLeft = 0;
            this.fBan.IconMarginRight = 0;
            this.fBan.IconRightVisible = true;
            this.fBan.IconRightZoom = 0D;
            this.fBan.IconVisible = true;
            this.fBan.IconZoom = 90D;
            this.fBan.IsTab = false;
            this.fBan.Location = new System.Drawing.Point(0, 306);
            this.fBan.Name = "fBan";
            this.fBan.Normalcolor = System.Drawing.Color.Orange;
            this.fBan.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fBan.OnHoverTextColor = System.Drawing.Color.White;
            this.fBan.selected = false;
            this.fBan.Size = new System.Drawing.Size(199, 48);
            this.fBan.TabIndex = 5;
            this.fBan.Text = "Bàn";
            this.fBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fBan.Textcolor = System.Drawing.Color.Black;
            this.fBan.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // fNhanVien
            // 
            this.fNhanVien.Activecolor = System.Drawing.Color.Orange;
            this.fNhanVien.BackColor = System.Drawing.Color.Orange;
            this.fNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fNhanVien.BorderRadius = 0;
            this.fNhanVien.ButtonText = "Nhân Viên";
            this.fNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.fNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.fNhanVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("fNhanVien.Iconimage")));
            this.fNhanVien.Iconimage_right = null;
            this.fNhanVien.Iconimage_right_Selected = null;
            this.fNhanVien.Iconimage_Selected = null;
            this.fNhanVien.IconMarginLeft = 0;
            this.fNhanVien.IconMarginRight = 0;
            this.fNhanVien.IconRightVisible = true;
            this.fNhanVien.IconRightZoom = 0D;
            this.fNhanVien.IconVisible = true;
            this.fNhanVien.IconZoom = 90D;
            this.fNhanVien.IsTab = false;
            this.fNhanVien.Location = new System.Drawing.Point(0, 251);
            this.fNhanVien.Name = "fNhanVien";
            this.fNhanVien.Normalcolor = System.Drawing.Color.Orange;
            this.fNhanVien.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fNhanVien.OnHoverTextColor = System.Drawing.Color.White;
            this.fNhanVien.selected = false;
            this.fNhanVien.Size = new System.Drawing.Size(199, 48);
            this.fNhanVien.TabIndex = 4;
            this.fNhanVien.Text = "Nhân Viên";
            this.fNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fNhanVien.Textcolor = System.Drawing.Color.Black;
            this.fNhanVien.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.fNhanVien.Click += new System.EventHandler(this.cButtonFlat5_Click);
            // 
            // fDanhMuc
            // 
            this.fDanhMuc.Activecolor = System.Drawing.Color.Orange;
            this.fDanhMuc.BackColor = System.Drawing.Color.Orange;
            this.fDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fDanhMuc.BorderRadius = 0;
            this.fDanhMuc.ButtonText = "Danh Mục";
            this.fDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fDanhMuc.DisabledColor = System.Drawing.Color.Gray;
            this.fDanhMuc.Iconcolor = System.Drawing.Color.Transparent;
            this.fDanhMuc.Iconimage = ((System.Drawing.Image)(resources.GetObject("fDanhMuc.Iconimage")));
            this.fDanhMuc.Iconimage_right = null;
            this.fDanhMuc.Iconimage_right_Selected = null;
            this.fDanhMuc.Iconimage_Selected = null;
            this.fDanhMuc.IconMarginLeft = 0;
            this.fDanhMuc.IconMarginRight = 0;
            this.fDanhMuc.IconRightVisible = true;
            this.fDanhMuc.IconRightZoom = 0D;
            this.fDanhMuc.IconVisible = true;
            this.fDanhMuc.IconZoom = 90D;
            this.fDanhMuc.IsTab = false;
            this.fDanhMuc.Location = new System.Drawing.Point(0, 197);
            this.fDanhMuc.Name = "fDanhMuc";
            this.fDanhMuc.Normalcolor = System.Drawing.Color.Orange;
            this.fDanhMuc.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fDanhMuc.OnHoverTextColor = System.Drawing.Color.White;
            this.fDanhMuc.selected = false;
            this.fDanhMuc.Size = new System.Drawing.Size(199, 48);
            this.fDanhMuc.TabIndex = 3;
            this.fDanhMuc.Text = "Danh Mục";
            this.fDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fDanhMuc.Textcolor = System.Drawing.Color.Black;
            this.fDanhMuc.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.fDanhMuc.Click += new System.EventHandler(this.cButtonFlat4_Click);
            // 
            // fNhaCungCap
            // 
            this.fNhaCungCap.Activecolor = System.Drawing.Color.Orange;
            this.fNhaCungCap.BackColor = System.Drawing.Color.Orange;
            this.fNhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fNhaCungCap.BorderRadius = 0;
            this.fNhaCungCap.ButtonText = "Nhà Cung Cấp";
            this.fNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fNhaCungCap.DisabledColor = System.Drawing.Color.Gray;
            this.fNhaCungCap.Iconcolor = System.Drawing.Color.Transparent;
            this.fNhaCungCap.Iconimage = ((System.Drawing.Image)(resources.GetObject("fNhaCungCap.Iconimage")));
            this.fNhaCungCap.Iconimage_right = null;
            this.fNhaCungCap.Iconimage_right_Selected = null;
            this.fNhaCungCap.Iconimage_Selected = null;
            this.fNhaCungCap.IconMarginLeft = 0;
            this.fNhaCungCap.IconMarginRight = 0;
            this.fNhaCungCap.IconRightVisible = true;
            this.fNhaCungCap.IconRightZoom = 0D;
            this.fNhaCungCap.IconVisible = true;
            this.fNhaCungCap.IconZoom = 90D;
            this.fNhaCungCap.IsTab = false;
            this.fNhaCungCap.Location = new System.Drawing.Point(0, 143);
            this.fNhaCungCap.Name = "fNhaCungCap";
            this.fNhaCungCap.Normalcolor = System.Drawing.Color.Orange;
            this.fNhaCungCap.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fNhaCungCap.OnHoverTextColor = System.Drawing.Color.White;
            this.fNhaCungCap.selected = false;
            this.fNhaCungCap.Size = new System.Drawing.Size(199, 48);
            this.fNhaCungCap.TabIndex = 2;
            this.fNhaCungCap.Text = "Nhà Cung Cấp";
            this.fNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fNhaCungCap.Textcolor = System.Drawing.Color.Black;
            this.fNhaCungCap.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.fNhaCungCap.Click += new System.EventHandler(this.cButtonFlat3_Click);
            // 
            // fNguyenLieu
            // 
            this.fNguyenLieu.Activecolor = System.Drawing.Color.Orange;
            this.fNguyenLieu.BackColor = System.Drawing.Color.Orange;
            this.fNguyenLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fNguyenLieu.BorderRadius = 0;
            this.fNguyenLieu.ButtonText = "Nguyên Liệu";
            this.fNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fNguyenLieu.DisabledColor = System.Drawing.Color.Gray;
            this.fNguyenLieu.Iconcolor = System.Drawing.Color.Transparent;
            this.fNguyenLieu.Iconimage = ((System.Drawing.Image)(resources.GetObject("fNguyenLieu.Iconimage")));
            this.fNguyenLieu.Iconimage_right = null;
            this.fNguyenLieu.Iconimage_right_Selected = null;
            this.fNguyenLieu.Iconimage_Selected = null;
            this.fNguyenLieu.IconMarginLeft = 0;
            this.fNguyenLieu.IconMarginRight = 0;
            this.fNguyenLieu.IconRightVisible = true;
            this.fNguyenLieu.IconRightZoom = 0D;
            this.fNguyenLieu.IconVisible = true;
            this.fNguyenLieu.IconZoom = 90D;
            this.fNguyenLieu.IsTab = false;
            this.fNguyenLieu.Location = new System.Drawing.Point(0, 89);
            this.fNguyenLieu.Name = "fNguyenLieu";
            this.fNguyenLieu.Normalcolor = System.Drawing.Color.Orange;
            this.fNguyenLieu.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.fNguyenLieu.OnHoverTextColor = System.Drawing.Color.White;
            this.fNguyenLieu.selected = false;
            this.fNguyenLieu.Size = new System.Drawing.Size(199, 48);
            this.fNguyenLieu.TabIndex = 1;
            this.fNguyenLieu.Text = "Nguyên Liệu";
            this.fNguyenLieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fNguyenLieu.Textcolor = System.Drawing.Color.Black;
            this.fNguyenLieu.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.fNguyenLieu.Click += new System.EventHandler(this.cButtonFlat2_Click);
            // 
            // cButtonFlat1
            // 
            this.cButtonFlat1.Activecolor = System.Drawing.Color.Orange;
            this.cButtonFlat1.BackColor = System.Drawing.Color.Orange;
            this.cButtonFlat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cButtonFlat1.BorderRadius = 0;
            this.cButtonFlat1.ButtonText = "QUÁN MỲ CAY";
            this.cButtonFlat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButtonFlat1.DisabledColor = System.Drawing.Color.Gray;
            this.cButtonFlat1.Iconcolor = System.Drawing.Color.Transparent;
            this.cButtonFlat1.Iconimage = ((System.Drawing.Image)(resources.GetObject("cButtonFlat1.Iconimage")));
            this.cButtonFlat1.Iconimage_right = null;
            this.cButtonFlat1.Iconimage_right_Selected = null;
            this.cButtonFlat1.Iconimage_Selected = null;
            this.cButtonFlat1.IconMarginLeft = 0;
            this.cButtonFlat1.IconMarginRight = 0;
            this.cButtonFlat1.IconRightVisible = true;
            this.cButtonFlat1.IconRightZoom = 0D;
            this.cButtonFlat1.IconVisible = true;
            this.cButtonFlat1.IconZoom = 90D;
            this.cButtonFlat1.IsTab = false;
            this.cButtonFlat1.Location = new System.Drawing.Point(4, 8);
            this.cButtonFlat1.Name = "cButtonFlat1";
            this.cButtonFlat1.Normalcolor = System.Drawing.Color.Orange;
            this.cButtonFlat1.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.cButtonFlat1.OnHoverTextColor = System.Drawing.Color.White;
            this.cButtonFlat1.selected = false;
            this.cButtonFlat1.Size = new System.Drawing.Size(192, 48);
            this.cButtonFlat1.TabIndex = 0;
            this.cButtonFlat1.Text = "QUÁN MỲ CAY";
            this.cButtonFlat1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cButtonFlat1.Textcolor = System.Drawing.Color.Black;
            this.cButtonFlat1.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButtonFlat1.Click += new System.EventHandler(this.cButtonFlat1_Click);
            // 
            // ufNhanVIen1
            // 
            this.ufNhanVIen1.BackColor = System.Drawing.Color.White;
            this.ufNhanVIen1.Location = new System.Drawing.Point(174, 0);
            this.ufNhanVIen1.Name = "ufNhanVIen1";
            this.ufNhanVIen1.Size = new System.Drawing.Size(1010, 603);
            this.ufNhanVIen1.TabIndex = 9;
            // 
            // ufDanhMuc1
            // 
            this.ufDanhMuc1.BackColor = System.Drawing.Color.White;
            this.ufDanhMuc1.Location = new System.Drawing.Point(174, 0);
            this.ufDanhMuc1.Name = "ufDanhMuc1";
            this.ufDanhMuc1.Size = new System.Drawing.Size(980, 542);
            this.ufDanhMuc1.TabIndex = 8;
            // 
            // ufNhaCungCap1
            // 
            this.ufNhaCungCap1.BackColor = System.Drawing.Color.White;
            this.ufNhaCungCap1.Location = new System.Drawing.Point(174, 0);
            this.ufNhaCungCap1.Name = "ufNhaCungCap1";
            this.ufNhaCungCap1.Size = new System.Drawing.Size(1021, 590);
            this.ufNhaCungCap1.TabIndex = 7;
            // 
            // ufTrangChu1
            // 
            this.ufTrangChu1.BackColor = System.Drawing.Color.White;
            this.ufTrangChu1.Location = new System.Drawing.Point(174, 0);
            this.ufTrangChu1.Name = "ufTrangChu1";
            this.ufTrangChu1.Size = new System.Drawing.Size(908, 577);
            this.ufTrangChu1.TabIndex = 5;
            // 
            // ufQuyen1
            // 
            this.ufQuyen1.BackColor = System.Drawing.Color.White;
            this.ufQuyen1.Location = new System.Drawing.Point(174, 3);
            this.ufQuyen1.Name = "ufQuyen1";
            this.ufQuyen1.Size = new System.Drawing.Size(1010, 574);
            this.ufQuyen1.TabIndex = 10;
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 583);
            this.Controls.Add(this.ufQuyen1);
            this.Controls.Add(this.ufNhanVIen1);
            this.Controls.Add(this.ufDanhMuc1);
            this.Controls.Add(this.ufNhaCungCap1);
            this.Controls.Add(this.ufTrangChu1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Name = "fTrangChu";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTrangChu_FormClosed);
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private CustomControl.ControlCustom.CButtonFlat cButtonFlat1;
        private CustomControl.ControlCustom.CButtonFlat fDoanhThu;
        private CustomControl.ControlCustom.CButtonFlat fQuyen;
        private CustomControl.ControlCustom.CButtonFlat fHoaDon;
        private CustomControl.ControlCustom.CButtonFlat fBan;
        private CustomControl.ControlCustom.CButtonFlat fNhanVien;
        private CustomControl.ControlCustom.CButtonFlat fDanhMuc;
        private CustomControl.ControlCustom.CButtonFlat fNhaCungCap;
        private CustomControl.ControlCustom.CButtonFlat fNguyenLieu;
        private CustomControl.ControlCustom.CButtonFlat btnThoat;
        private FormControl.UFTrangChu ufTrangChu1;
        private FormControl.UFNhaCungCap ufNhaCungCap1;
        private FormControl.UFDanhMuc ufDanhMuc1;
        private FormControl.UFNhanVIen ufNhanVIen1;
        private FormControl.UFQuyen ufQuyen1;
        
    }
}