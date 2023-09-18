namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Update_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        NV_Id = c.String(nullable: false, maxLength: 128),
                        NV_Ten = c.String(maxLength: 50),
                        NV_GioiTinh = c.String(),
                        NV_NgaySinh = c.DateTime(nullable: false),
                        NV_DiaChi = c.String(maxLength: 50),
                        NV_SDT = c.String(),
                        NV_TinhTrang = c.String(),
                        QA_DiaChiId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NV_Id)
                .ForeignKey("dbo.QuanAn", t => t.QA_DiaChiId)
                .Index(t => t.QA_DiaChiId);
            
            CreateTable(
                "dbo.QuanAn",
                c => new
                    {
                        QA_DiaChi = c.String(nullable: false, maxLength: 50),
                        QA_Chu = c.String(),
                        QA_Ten = c.String(),
                        QA_TK = c.String(),
                        QA_MK = c.String(),
                    })
                .PrimaryKey(t => t.QA_DiaChi);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        TK_Id = c.String(nullable: false, maxLength: 128),
                        TK_Ten = c.String(),
                        TK_MatKhau = c.String(),
                        TK_NhanVien = c.String(),
                        TK_NguoiDung = c.String(),
                    })
                .PrimaryKey(t => t.TK_Id);
            
            AlterColumn("dbo.NguoiDung", "NG_DiaChi", c => c.String(maxLength: 50));
            AlterColumn("dbo.NguoiDung", "NG_PhongBan", c => c.String(maxLength: 50));
            AlterColumn("dbo.NguoiDung", "NG_MatKhau", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanVien", "QA_DiaChiId", "dbo.QuanAn");
            DropIndex("dbo.NhanVien", new[] { "QA_DiaChiId" });
            AlterColumn("dbo.NguoiDung", "NG_MatKhau", c => c.String());
            AlterColumn("dbo.NguoiDung", "NG_PhongBan", c => c.String());
            AlterColumn("dbo.NguoiDung", "NG_DiaChi", c => c.String());
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.QuanAn");
            DropTable("dbo.NhanVien");
        }
    }
}
