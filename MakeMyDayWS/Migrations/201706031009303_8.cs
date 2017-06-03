namespace MakeMyDayWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accounts", "EncodedMustUnderstand");
            DropColumn("dbo.Accounts", "EncodedMustUnderstand12");
            DropColumn("dbo.Accounts", "MustUnderstand");
            DropColumn("dbo.Accounts", "Actor");
            DropColumn("dbo.Accounts", "Role");
            DropColumn("dbo.Accounts", "DidUnderstand");
            DropColumn("dbo.Accounts", "EncodedRelay");
            DropColumn("dbo.Accounts", "Relay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "Relay", c => c.Boolean(nullable: false));
            AddColumn("dbo.Accounts", "EncodedRelay", c => c.String());
            AddColumn("dbo.Accounts", "DidUnderstand", c => c.Boolean(nullable: false));
            AddColumn("dbo.Accounts", "Role", c => c.String());
            AddColumn("dbo.Accounts", "Actor", c => c.String());
            AddColumn("dbo.Accounts", "MustUnderstand", c => c.Boolean(nullable: false));
            AddColumn("dbo.Accounts", "EncodedMustUnderstand12", c => c.String());
            AddColumn("dbo.Accounts", "EncodedMustUnderstand", c => c.String());
        }
    }
}
