namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class themthuoctinhisDeletedchonguyenlieu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguyenLieu", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguyenLieu", "isDeleted");
        }
    }
}
