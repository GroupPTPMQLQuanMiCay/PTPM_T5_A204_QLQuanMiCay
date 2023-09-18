namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationsFist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NguoiDung",
                c => new
                    {
                        NG_Id = c.String(nullable: false, maxLength: 128),
                        NG_DiaChi = c.String(),
                        NG_PhongBan = c.String(),
                        NG_MatKhau = c.String(),
                    })
                .PrimaryKey(t => t.NG_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NguoiDung");
        }
    }
}
