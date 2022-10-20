namespace Supermarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Casher_Admin : DbMigration
    {
        public override void Up()
        {
 
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cashers", new[] { "Email" });
            DropIndex("dbo.Admins", new[] { "Email" });
            DropTable("dbo.Admins");
        }
    }
}
