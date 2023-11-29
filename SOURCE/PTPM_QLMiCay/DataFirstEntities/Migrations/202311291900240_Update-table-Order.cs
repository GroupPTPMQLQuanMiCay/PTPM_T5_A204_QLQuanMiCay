namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatetableOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrDer", "O_DonGia", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrDer", "O_DonGia");
        }
    }
}
