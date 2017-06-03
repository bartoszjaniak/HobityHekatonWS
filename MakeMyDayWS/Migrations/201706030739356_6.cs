namespace MakeMyDayWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserAccounts", newName: "Accounts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Accounts", newName: "UserAccounts");
        }
    }
}
