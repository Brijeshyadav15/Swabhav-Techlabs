namespace ShoppingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated10thMar : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropColumn("dbo.Addresses", "User_Id");
            DropColumn("dbo.Orders", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "User_Id", c => c.Guid());
            AddColumn("dbo.Addresses", "User_Id", c => c.Guid());
            CreateIndex("dbo.Orders", "User_Id");
            CreateIndex("dbo.Addresses", "User_Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Addresses", "User_Id", "dbo.Users", "Id");
        }
    }
}
