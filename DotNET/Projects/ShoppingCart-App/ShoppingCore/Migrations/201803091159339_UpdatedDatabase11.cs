namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDatabase11 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.LineItems", "OrderId");
            CreateIndex("dbo.LineItems", "ProductId");
            AddForeignKey("dbo.LineItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LineItems", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.LineItems", "ProductId", "dbo.Products");
            DropIndex("dbo.LineItems", new[] { "ProductId" });
            DropIndex("dbo.LineItems", new[] { "OrderId" });
        }
    }
}
