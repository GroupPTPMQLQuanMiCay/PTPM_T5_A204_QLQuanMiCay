namespace DataFirstEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetablechitietphieudate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuDat", "createdBy", c => c.String());
            AddColumn("dbo.PhieuDat", "createdAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.PhieuDat", "updatedBy", c => c.String());
            AddColumn("dbo.PhieuDat", "updatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.PhieuDat", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.PhieuDat", "isSentSupplier", c => c.Boolean(nullable: false));
            AddColumn("dbo.PhieuDat", "sentSupplierBy", c => c.String());
            AddColumn("dbo.CTPhieuDat", "NL_Gia", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CTPhieuDat", "NL_Gia");
            DropColumn("dbo.PhieuDat", "sentSupplierBy");
            DropColumn("dbo.PhieuDat", "isSentSupplier");
            DropColumn("dbo.PhieuDat", "isDeleted");
            DropColumn("dbo.PhieuDat", "updatedAt");
            DropColumn("dbo.PhieuDat", "updatedBy");
            DropColumn("dbo.PhieuDat", "createdAt");
            DropColumn("dbo.PhieuDat", "createdBy");
        }
    }
}
