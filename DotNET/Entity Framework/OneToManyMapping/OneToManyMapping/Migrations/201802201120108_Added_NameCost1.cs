namespace OneToManyMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_NameCost1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductName = c.String(),
                        ProductCost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "OrderTotal", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "ProductName");
            DropColumn("dbo.Orders", "ProductCost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ProductCost", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ProductName", c => c.String());
            DropForeignKey("dbo.LineItems", "OrderId", "dbo.Orders");
            DropIndex("dbo.LineItems", new[] { "OrderId" });
            DropColumn("dbo.Orders", "OrderTotal");
            DropTable("dbo.Products");
            DropTable("dbo.LineItems");
        }
    }
}
