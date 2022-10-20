namespace Supermarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transaction_TransactionDetail_Product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
