namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedVersion : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "Version");
            DropColumn("dbo.LineItems", "Version");
            DropColumn("dbo.Orders", "Version");
            DropColumn("dbo.Products", "Version");
            DropColumn("dbo.ProductCategories", "Version");
            DropColumn("dbo.Users", "Version");
            DropColumn("dbo.WishLists", "Version");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WishLists", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.ProductCategories", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.LineItems", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "Version", c => c.Int(nullable: false));
        }
    }
}
