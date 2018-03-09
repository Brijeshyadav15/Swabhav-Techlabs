namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedProuductOptions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductCategories", "ParentCategory_Id", "dbo.ProductCategories");
            DropForeignKey("dbo.LineItems", "WishList_Id", "dbo.WishLists");
            DropIndex("dbo.LineItems", new[] { "WishList_Id" });
            DropIndex("dbo.ProductCategories", new[] { "ParentCategory_Id" });
            DropColumn("dbo.LineItems", "WishList_Id");
            DropColumn("dbo.ProductCategories", "ParentCategory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductCategories", "ParentCategory_Id", c => c.Guid());
            AddColumn("dbo.LineItems", "WishList_Id", c => c.Guid());
            CreateIndex("dbo.ProductCategories", "ParentCategory_Id");
            CreateIndex("dbo.LineItems", "WishList_Id");
            AddForeignKey("dbo.LineItems", "WishList_Id", "dbo.WishLists", "Id");
            AddForeignKey("dbo.ProductCategories", "ParentCategory_Id", "dbo.ProductCategories", "Id");
        }
    }
}
