namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        StreetAddress = c.String(),
                        City = c.String(),
                        Pincode = c.String(),
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        WishList_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WishLists", t => t.WishList_Id)
                .Index(t => t.WishList_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        OrderTotal = c.Double(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        ProductImage = c.String(),
                        Version = c.Int(nullable: false),
                        parentCategory_Id = c.Guid(),
                        ProductCategory_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.parentCategory_Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategory_Id)
                .Index(t => t.parentCategory_Id)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        ParentCategory_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.ParentCategory_Id)
                .Index(t => t.ParentCategory_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        ProfilePic = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Contact = c.String(),
                        Location = c.String(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        Name = c.String(),
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineItems", "WishList_Id", "dbo.WishLists");
            DropForeignKey("dbo.Products", "ProductCategory_Id", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "parentCategory_Id", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductCategories", "ParentCategory_Id", "dbo.ProductCategories");
            DropIndex("dbo.ProductCategories", new[] { "ParentCategory_Id" });
            DropIndex("dbo.Products", new[] { "ProductCategory_Id" });
            DropIndex("dbo.Products", new[] { "parentCategory_Id" });
            DropIndex("dbo.LineItems", new[] { "WishList_Id" });
            DropTable("dbo.WishLists");
            DropTable("dbo.Users");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.LineItems");
            DropTable("dbo.Addresses");
        }
    }
}
