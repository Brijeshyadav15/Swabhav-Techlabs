namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedProductModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "parentCategory_Id", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "ProductCategory_Id", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "parentCategory_Id" });
            DropIndex("dbo.Products", new[] { "ProductCategory_Id" });
            DropColumn("dbo.Products", "parentCategory_Id");
            DropColumn("dbo.Products", "ProductCategory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductCategory_Id", c => c.Guid());
            AddColumn("dbo.Products", "parentCategory_Id", c => c.Guid());
            CreateIndex("dbo.Products", "ProductCategory_Id");
            CreateIndex("dbo.Products", "parentCategory_Id");
            AddForeignKey("dbo.Products", "ProductCategory_Id", "dbo.ProductCategories", "Id");
            AddForeignKey("dbo.Products", "parentCategory_Id", "dbo.ProductCategories", "Id");
        }
    }
}
