namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class themthongtinbangnhacungcap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhaCungCap", "createdBy", c => c.String());
            AddColumn("dbo.NhaCungCap", "createdAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.NhaCungCap", "updatedBy", c => c.String());
            AddColumn("dbo.NhaCungCap", "updatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.NhaCungCap", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhaCungCap", "isDeleted");
            DropColumn("dbo.NhaCungCap", "updatedAt");
            DropColumn("dbo.NhaCungCap", "updatedBy");
            DropColumn("dbo.NhaCungCap", "createdAt");
            DropColumn("dbo.NhaCungCap", "createdBy");
        }
    }
}
