namespace OneToManyMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_NameCost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ProductName", c => c.String());
            AddColumn("dbo.Orders", "ProductCost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ProductCost");
            DropColumn("dbo.Orders", "ProductName");
        }
    }
}
