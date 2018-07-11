namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Accounts", new[] { "UserId" });
            CreateTable(
                "dbo.CustomerAccounts",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        PickupDay = c.String(),
                        ExtraPickup = c.String(),
                        AmountDue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        PickupDay = c.String(),
                        ExtraPickup = c.String(),
                        AmountDue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            DropForeignKey("dbo.CustomerAccounts", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.CustomerAccounts", new[] { "UserId" });
            DropTable("dbo.CustomerAccounts");
            CreateIndex("dbo.Accounts", "UserId");
            AddForeignKey("dbo.Accounts", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
