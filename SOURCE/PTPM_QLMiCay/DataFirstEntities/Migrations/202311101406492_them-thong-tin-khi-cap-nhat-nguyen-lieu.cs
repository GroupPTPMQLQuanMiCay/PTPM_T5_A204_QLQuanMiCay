namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class themthongtinkhicapnhatnguyenlieu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguyenLieu", "createdBy", c => c.String());
            AddColumn("dbo.NguyenLieu", "createdAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.NguyenLieu", "updatedBy", c => c.String());
            AddColumn("dbo.NguyenLieu", "updatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguyenLieu", "updatedAt");
            DropColumn("dbo.NguyenLieu", "updatedBy");
            DropColumn("dbo.NguyenLieu", "createdAt");
            DropColumn("dbo.NguyenLieu", "createdBy");
        }
    }
}
