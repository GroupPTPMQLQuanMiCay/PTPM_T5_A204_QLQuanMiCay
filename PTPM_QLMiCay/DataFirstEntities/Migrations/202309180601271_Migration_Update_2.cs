namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Update_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ban",
                c => new
                    {
                        B_SoBan = c.Int(nullable: false, identity: true),
                        B_ViTri = c.String(),
                    })
                .PrimaryKey(t => t.B_SoBan);
            
            CreateTable(
                "dbo.ChiTietNhap",
                c => new
                    {
                        NL_Id = c.Int(nullable: false),
                        HDN_Id = c.Int(nullable: false),
                        CTN_SoLuong = c.Int(nullable: false),
                        CTN_Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NL_Id, t.HDN_Id })
                .ForeignKey("dbo.HoaDonNhap", t => t.HDN_Id, cascadeDelete: true)
                .ForeignKey("dbo.NguyenLieu", t => t.NL_Id, cascadeDelete: true)
                .Index(t => t.NL_Id)
                .Index(t => t.HDN_Id);
            
            CreateTable(
                "dbo.HoaDonNhap",
                c => new
                    {
                        HDN_Id = c.Int(nullable: false, identity: true),
                        NV_Id = c.String(maxLength: 128),
                        HDN_Ngaynhap = c.DateTime(nullable: false),
                        HDN_ThanhTien = c.Int(nullable: false),
                        PD_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HDN_Id)
                .ForeignKey("dbo.NhanVien", t => t.NV_Id)
                .ForeignKey("dbo.PhieuDat", t => t.PD_Id, cascadeDelete: true)
                .Index(t => t.NV_Id)
                .Index(t => t.PD_Id);
            
            CreateTable(
                "dbo.PhieuDat",
                c => new
                    {
                        PD_Id = c.Int(nullable: false, identity: true),
                        PD_Date = c.DateTime(nullable: false),
                        PD_TrangThai = c.String(),
                    })
                .PrimaryKey(t => t.PD_Id);
            
            CreateTable(
                "dbo.NguyenLieu",
                c => new
                    {
                        NL_Id = c.Int(nullable: false, identity: true),
                        NL_Ten = c.String(maxLength: 50),
                        NL_DonViTinh = c.String(),
                        NL_SoLuong = c.Int(nullable: false),
                        NCC_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NL_Id)
                .ForeignKey("dbo.NhaCungCap", t => t.NCC_Id, cascadeDelete: true)
                .Index(t => t.NCC_Id);
            
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        NCC_Id = c.Int(nullable: false, identity: true),
                        NCC_Ten = c.String(maxLength: 50),
                        NCC_SDT = c.String(),
                        NCC_DiaChi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NCC_Id);
            
            CreateTable(
                "dbo.CTPhieuDat",
                c => new
                    {
                        PD_Id = c.Int(nullable: false),
                        NL_Id = c.Int(nullable: false),
                        soluong = c.Int(nullable: false),
                        DaGiao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PD_Id, t.NL_Id })
                .ForeignKey("dbo.NguyenLieu", t => t.NL_Id, cascadeDelete: true)
                .ForeignKey("dbo.PhieuDat", t => t.PD_Id, cascadeDelete: true)
                .Index(t => t.PD_Id)
                .Index(t => t.NL_Id);
            
            CreateTable(
                "dbo.DanhMuc",
                c => new
                    {
                        DM_Id = c.Int(nullable: false, identity: true),
                        DM_Ten = c.String(),
                        QA_DiaChi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DM_Id)
                .ForeignKey("dbo.QuanAn", t => t.QA_DiaChi)
                .Index(t => t.QA_DiaChi);
            
            CreateTable(
                "dbo.GiaNguyenLieu",
                c => new
                    {
                        NL_Id = c.Int(nullable: false),
                        NgayThayDoi = c.DateTime(nullable: false),
                        NL_Gia = c.Int(nullable: false),
                        NV_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.NL_Id, t.NgayThayDoi })
                .ForeignKey("dbo.NguyenLieu", t => t.NL_Id, cascadeDelete: true)
                .ForeignKey("dbo.NhanVien", t => t.NV_Id)
                .Index(t => t.NL_Id)
                .Index(t => t.NV_Id);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        HD_Id = c.Int(nullable: false, identity: true),
                        NV_Id = c.String(maxLength: 128),
                        B_SoBan = c.Int(nullable: false),
                        HD_ThanhTien = c.Int(nullable: false),
                        HD_NgayXuat = c.DateTime(nullable: false),
                        HD_TrangThai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HD_Id)
                .ForeignKey("dbo.Ban", t => t.B_SoBan, cascadeDelete: true)
                .ForeignKey("dbo.NhanVien", t => t.NV_Id)
                .Index(t => t.NV_Id)
                .Index(t => t.B_SoBan);
            
            CreateTable(
                "dbo.Mon_Co_NL",
                c => new
                    {
                        NL_Id = c.Int(nullable: false),
                        M_Ten = c.String(nullable: false, maxLength: 128),
                        MNL_DonViTinh = c.String(),
                        MNL_SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NL_Id, t.M_Ten })
                .ForeignKey("dbo.Mon", t => t.M_Ten, cascadeDelete: true)
                .ForeignKey("dbo.NguyenLieu", t => t.NL_Id, cascadeDelete: true)
                .Index(t => t.NL_Id)
                .Index(t => t.M_Ten);
            
            CreateTable(
                "dbo.Mon",
                c => new
                    {
                        M_Ten = c.String(nullable: false, maxLength: 128),
                        DM_Id = c.Int(nullable: false),
                        M_Gia = c.Int(nullable: false),
                        M_IMG = c.String(),
                    })
                .PrimaryKey(t => t.M_Ten)
                .ForeignKey("dbo.DanhMuc", t => t.DM_Id, cascadeDelete: true)
                .Index(t => t.DM_Id);
            
            CreateTable(
                "dbo.NL_TuongDong",
                c => new
                    {
                        STT = c.Int(nullable: false, identity: true),
                        NL_Id = c.Int(nullable: false),
                        NL_DonViTinh = c.String(),
                        NL_SoLuong = c.Int(nullable: false),
                        STT_ThayCho = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.STT)
                .ForeignKey("dbo.NguyenLieu", t => t.NL_Id, cascadeDelete: true)
                .Index(t => t.NL_Id);
            
            CreateTable(
                "dbo.OrDer",
                c => new
                    {
                        M_Ten = c.String(nullable: false, maxLength: 128),
                        HD_Id = c.Int(nullable: false),
                        O_SoLuong = c.Int(nullable: false),
                        O_Gia = c.Int(nullable: false),
                        O_GhiChu = c.String(),
                        O_ThoiGian = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.M_Ten, t.HD_Id })
                .ForeignKey("dbo.HoaDon", t => t.HD_Id, cascadeDelete: true)
                .ForeignKey("dbo.Mon", t => t.M_Ten, cascadeDelete: true)
                .Index(t => t.M_Ten)
                .Index(t => t.HD_Id);
            
            CreateTable(
                "dbo.QuanLyBep",
                c => new
                    {
                        NV_Id = c.String(nullable: false, maxLength: 128),
                        NL_Id = c.Int(nullable: false),
                        QLB_SoLuong = c.Int(nullable: false),
                        QLB_Ngay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.NV_Id, t.NL_Id })
                .ForeignKey("dbo.NguyenLieu", t => t.NL_Id, cascadeDelete: true)
                .ForeignKey("dbo.NhanVien", t => t.NV_Id, cascadeDelete: true)
                .Index(t => t.NV_Id)
                .Index(t => t.NL_Id);
            
            CreateTable(
                "dbo.TinhTrangMon",
                c => new
                    {
                        Ma_TT = c.Int(nullable: false, identity: true),
                        Ma_DienGiai = c.String(),
                    })
                .PrimaryKey(t => t.Ma_TT);
            
            CreateTable(
                "dbo.TinhTrangThucHien",
                c => new
                    {
                        Ma_TT = c.Int(nullable: false, identity: true),
                        Ma_DienGiai = c.String(),
                    })
                .PrimaryKey(t => t.Ma_TT);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuanLyBep", "NV_Id", "dbo.NhanVien");
            DropForeignKey("dbo.QuanLyBep", "NL_Id", "dbo.NguyenLieu");
            DropForeignKey("dbo.OrDer", "M_Ten", "dbo.Mon");
            DropForeignKey("dbo.OrDer", "HD_Id", "dbo.HoaDon");
            DropForeignKey("dbo.NL_TuongDong", "NL_Id", "dbo.NguyenLieu");
            DropForeignKey("dbo.Mon_Co_NL", "NL_Id", "dbo.NguyenLieu");
            DropForeignKey("dbo.Mon_Co_NL", "M_Ten", "dbo.Mon");
            DropForeignKey("dbo.Mon", "DM_Id", "dbo.DanhMuc");
            DropForeignKey("dbo.HoaDon", "NV_Id", "dbo.NhanVien");
            DropForeignKey("dbo.HoaDon", "B_SoBan", "dbo.Ban");
            DropForeignKey("dbo.GiaNguyenLieu", "NV_Id", "dbo.NhanVien");
            DropForeignKey("dbo.GiaNguyenLieu", "NL_Id", "dbo.NguyenLieu");
            DropForeignKey("dbo.DanhMuc", "QA_DiaChi", "dbo.QuanAn");
            DropForeignKey("dbo.CTPhieuDat", "PD_Id", "dbo.PhieuDat");
            DropForeignKey("dbo.CTPhieuDat", "NL_Id", "dbo.NguyenLieu");
            DropForeignKey("dbo.ChiTietNhap", "NL_Id", "dbo.NguyenLieu");
            DropForeignKey("dbo.NguyenLieu", "NCC_Id", "dbo.NhaCungCap");
            DropForeignKey("dbo.ChiTietNhap", "HDN_Id", "dbo.HoaDonNhap");
            DropForeignKey("dbo.HoaDonNhap", "PD_Id", "dbo.PhieuDat");
            DropForeignKey("dbo.HoaDonNhap", "NV_Id", "dbo.NhanVien");
            DropIndex("dbo.QuanLyBep", new[] { "NL_Id" });
            DropIndex("dbo.QuanLyBep", new[] { "NV_Id" });
            DropIndex("dbo.OrDer", new[] { "HD_Id" });
            DropIndex("dbo.OrDer", new[] { "M_Ten" });
            DropIndex("dbo.NL_TuongDong", new[] { "NL_Id" });
            DropIndex("dbo.Mon", new[] { "DM_Id" });
            DropIndex("dbo.Mon_Co_NL", new[] { "M_Ten" });
            DropIndex("dbo.Mon_Co_NL", new[] { "NL_Id" });
            DropIndex("dbo.HoaDon", new[] { "B_SoBan" });
            DropIndex("dbo.HoaDon", new[] { "NV_Id" });
            DropIndex("dbo.GiaNguyenLieu", new[] { "NV_Id" });
            DropIndex("dbo.GiaNguyenLieu", new[] { "NL_Id" });
            DropIndex("dbo.DanhMuc", new[] { "QA_DiaChi" });
            DropIndex("dbo.CTPhieuDat", new[] { "NL_Id" });
            DropIndex("dbo.CTPhieuDat", new[] { "PD_Id" });
            DropIndex("dbo.NguyenLieu", new[] { "NCC_Id" });
            DropIndex("dbo.HoaDonNhap", new[] { "PD_Id" });
            DropIndex("dbo.HoaDonNhap", new[] { "NV_Id" });
            DropIndex("dbo.ChiTietNhap", new[] { "HDN_Id" });
            DropIndex("dbo.ChiTietNhap", new[] { "NL_Id" });
            DropTable("dbo.TinhTrangThucHien");
            DropTable("dbo.TinhTrangMon");
            DropTable("dbo.QuanLyBep");
            DropTable("dbo.OrDer");
            DropTable("dbo.NL_TuongDong");
            DropTable("dbo.Mon");
            DropTable("dbo.Mon_Co_NL");
            DropTable("dbo.HoaDon");
            DropTable("dbo.GiaNguyenLieu");
            DropTable("dbo.DanhMuc");
            DropTable("dbo.CTPhieuDat");
            DropTable("dbo.NhaCungCap");
            DropTable("dbo.NguyenLieu");
            DropTable("dbo.PhieuDat");
            DropTable("dbo.HoaDonNhap");
            DropTable("dbo.ChiTietNhap");
            DropTable("dbo.Ban");
        }
    }
}
