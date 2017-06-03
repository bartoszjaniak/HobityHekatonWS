namespace MakeMyDayWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "user_ID", c => c.Int());
            CreateIndex("dbo.Accounts", "user_ID");
            AddForeignKey("dbo.Accounts", "user_ID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "user_ID", "dbo.Users");
            DropIndex("dbo.Accounts", new[] { "user_ID" });
            DropColumn("dbo.Accounts", "user_ID");
        }
    }
}
