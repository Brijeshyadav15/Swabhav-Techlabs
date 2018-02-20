namespace OneToManyMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        customerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.customerId, cascadeDelete: true)
                .Index(t => t.customerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "customerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "customerId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
