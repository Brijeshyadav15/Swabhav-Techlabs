namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDatabase1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "User_Id", c => c.Guid());
            AddColumn("dbo.LineItems", "WishList_Id", c => c.Guid());
            AddColumn("dbo.Orders", "User_Id", c => c.Guid());
            AddColumn("dbo.Products", "ProductCategory", c => c.Guid(nullable: false));
            CreateIndex("dbo.Addresses", "User_Id");
            CreateIndex("dbo.LineItems", "WishList_Id");
            CreateIndex("dbo.Orders", "User_Id");
            AddForeignKey("dbo.Addresses", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.LineItems", "WishList_Id", "dbo.WishLists", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineItems", "WishList_Id", "dbo.WishLists");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropIndex("dbo.LineItems", new[] { "WishList_Id" });
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropColumn("dbo.Products", "ProductCategory");
            DropColumn("dbo.Orders", "User_Id");
            DropColumn("dbo.LineItems", "WishList_Id");
            DropColumn("dbo.Addresses", "User_Id");
        }
    }
}
