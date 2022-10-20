namespace Supermarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transaction_TransactionDetail_Product2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Subtotal = c.Double(nullable: false),
                        product_Id = c.Int(),
                        Transaction_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.product_Id)
                .ForeignKey("dbo.Transactions", t => t.Transaction_Id)
                .Index(t => t.product_Id)
                .Index(t => t.Transaction_Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        Subtotal = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PaidAmount = c.Double(nullable: false),
                        Change = c.Double(nullable: false),
                        Casher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cashers", t => t.Casher_Id)
                .Index(t => t.Casher_Id);
            

            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionDetails", "Transaction_Id", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "Casher_Id", "dbo.Cashers");
            DropForeignKey("dbo.TransactionDetails", "product_Id", "dbo.Products");
            DropIndex("dbo.Transactions", new[] { "Casher_Id" });
            DropIndex("dbo.TransactionDetails", new[] { "Transaction_Id" });
            DropIndex("dbo.TransactionDetails", new[] { "product_Id" });
            DropTable("dbo.Cashers");
            DropTable("dbo.Transactions");
            DropTable("dbo.TransactionDetails");
        }
    }
}
