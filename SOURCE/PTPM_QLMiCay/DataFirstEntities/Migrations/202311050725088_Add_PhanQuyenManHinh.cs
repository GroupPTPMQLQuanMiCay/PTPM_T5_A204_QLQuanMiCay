namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_PhanQuyenManHinh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CapQuyenNhom",
                c => new
                    {
                        NQ_Id = c.String(nullable: false, maxLength: 128),
                        MH_Id = c.String(nullable: false, maxLength: 128),
                        Quyen_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.NQ_Id, t.MH_Id, t.Quyen_Id })
                .ForeignKey("dbo.ManHinh", t => t.MH_Id, cascadeDelete: true)
                .ForeignKey("dbo.NhomQuyen", t => t.NQ_Id, cascadeDelete: true)
                .ForeignKey("dbo.Quyen", t => t.Quyen_Id, cascadeDelete: true)
                .Index(t => t.NQ_Id)
                .Index(t => t.MH_Id)
                .Index(t => t.Quyen_Id);
            
            CreateTable(
                "dbo.ManHinh",
                c => new
                    {
                        MH_Id = c.String(nullable: false, maxLength: 128),
                        MH_HienThi = c.String(),
                    })
                .PrimaryKey(t => t.MH_Id);
            
            CreateTable(
                "dbo.NhomQuyen",
                c => new
                    {
                        NQ_Id = c.String(nullable: false, maxLength: 128),
                        NQ_Ten = c.String(),
                        NQ_HienThi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NQ_Id);
            
            CreateTable(
                "dbo.Quyen",
                c => new
                    {
                        Quyen_Id = c.String(nullable: false, maxLength: 128),
                        DienGiai = c.String(),
                    })
                .PrimaryKey(t => t.Quyen_Id);
            
            CreateTable(
                "dbo.NhomQuyen_NguoiDung",
                c => new
                    {
                        NG_Id = c.String(nullable: false, maxLength: 128),
                        NQ_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.NG_Id, t.NQ_Id })
                .ForeignKey("dbo.NguoiDung", t => t.NG_Id, cascadeDelete: true)
                .ForeignKey("dbo.NhomQuyen", t => t.NQ_Id, cascadeDelete: true)
                .Index(t => t.NG_Id)
                .Index(t => t.NQ_Id);
            
            AlterColumn("dbo.NguoiDung", "NG_PhongBan", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhomQuyen_NguoiDung", "NQ_Id", "dbo.NhomQuyen");
            DropForeignKey("dbo.NhomQuyen_NguoiDung", "NG_Id", "dbo.NguoiDung");
            DropForeignKey("dbo.CapQuyenNhom", "Quyen_Id", "dbo.Quyen");
            DropForeignKey("dbo.CapQuyenNhom", "NQ_Id", "dbo.NhomQuyen");
            DropForeignKey("dbo.CapQuyenNhom", "MH_Id", "dbo.ManHinh");
            DropIndex("dbo.NhomQuyen_NguoiDung", new[] { "NQ_Id" });
            DropIndex("dbo.NhomQuyen_NguoiDung", new[] { "NG_Id" });
            DropIndex("dbo.CapQuyenNhom", new[] { "Quyen_Id" });
            DropIndex("dbo.CapQuyenNhom", new[] { "MH_Id" });
            DropIndex("dbo.CapQuyenNhom", new[] { "NQ_Id" });
            AlterColumn("dbo.NguoiDung", "NG_PhongBan", c => c.String(maxLength: 50));
            DropTable("dbo.NhomQuyen_NguoiDung");
            DropTable("dbo.Quyen");
            DropTable("dbo.NhomQuyen");
            DropTable("dbo.ManHinh");
            DropTable("dbo.CapQuyenNhom");
        }
    }
}
