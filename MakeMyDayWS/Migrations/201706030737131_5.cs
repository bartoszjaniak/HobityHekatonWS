namespace MakeMyDayWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Accounts", newName: "UserAccounts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserAccounts", newName: "Accounts");
        }
    }
}
