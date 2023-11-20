namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetabletaikhoan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaiKhoan", "TK_NhanVien", c => c.String(maxLength: 128));
            AlterColumn("dbo.TaiKhoan", "TK_NguoiDung", c => c.String(maxLength: 128));
            CreateIndex("dbo.TaiKhoan", "TK_NhanVien");
            CreateIndex("dbo.TaiKhoan", "TK_NguoiDung");
            AddForeignKey("dbo.TaiKhoan", "TK_NguoiDung", "dbo.NguoiDung", "NG_Id");
            AddForeignKey("dbo.TaiKhoan", "TK_NhanVien", "dbo.NhanVien", "NV_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaiKhoan", "TK_NhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.TaiKhoan", "TK_NguoiDung", "dbo.NguoiDung");
            DropIndex("dbo.TaiKhoan", new[] { "TK_NguoiDung" });
            DropIndex("dbo.TaiKhoan", new[] { "TK_NhanVien" });
            AlterColumn("dbo.TaiKhoan", "TK_NguoiDung", c => c.String());
            AlterColumn("dbo.TaiKhoan", "TK_NhanVien", c => c.String());
        }
    }
}
