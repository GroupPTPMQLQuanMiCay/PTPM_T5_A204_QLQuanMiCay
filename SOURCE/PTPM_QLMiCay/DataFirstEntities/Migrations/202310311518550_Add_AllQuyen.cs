namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AllQuyen : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ChiTietNhomQuyen", newName: "CapQuyenNhom");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CapQuyenNhom", newName: "ChiTietNhomQuyen");
        }
    }
}
