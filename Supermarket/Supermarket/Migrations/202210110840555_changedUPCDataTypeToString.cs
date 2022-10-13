namespace Supermarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedUPCDataTypeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UPC", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UPC", c => c.Int(nullable: false));
        }
    }
}
