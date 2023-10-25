namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class them_tieu_de_cho_tin_tuc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TinTuc", "TieuDe", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TinTuc", "TieuDe");
        }
    }
}
