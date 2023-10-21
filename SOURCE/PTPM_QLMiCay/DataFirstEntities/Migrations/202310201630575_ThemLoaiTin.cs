namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemLoaiTin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiTinTuc",
                c => new
                    {
                        LoaiTin_Id = c.Int(nullable: false, identity: true),
                        TenLoaiTin = c.String(),
                    })
                .PrimaryKey(t => t.LoaiTin_Id);
            
            CreateTable(
                "dbo.TinTuc",
                c => new
                    {
                        TinTuc_Id = c.Int(nullable: false, identity: true),
                        NgayDang = c.DateTime(nullable: false),
                        NoiDung = c.String(),
                        NV_Id = c.String(maxLength: 128),
                        LoaiTin_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TinTuc_Id)
                .ForeignKey("dbo.LoaiTinTuc", t => t.LoaiTin_Id, cascadeDelete: true)
                .ForeignKey("dbo.NhanVien", t => t.NV_Id)
                .Index(t => t.NV_Id)
                .Index(t => t.LoaiTin_Id);
            
            AlterColumn("dbo.GiaNguyenLieu", "NL_Gia", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TinTuc", "NV_Id", "dbo.NhanVien");
            DropForeignKey("dbo.TinTuc", "LoaiTin_Id", "dbo.LoaiTinTuc");
            DropIndex("dbo.TinTuc", new[] { "LoaiTin_Id" });
            DropIndex("dbo.TinTuc", new[] { "NV_Id" });
            AlterColumn("dbo.GiaNguyenLieu", "NL_Gia", c => c.Int(nullable: false));
            DropTable("dbo.TinTuc");
            DropTable("dbo.LoaiTinTuc");
        }
    }
}
