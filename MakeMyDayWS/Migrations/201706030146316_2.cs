namespace MakeMyDayWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        login = c.String(),
                        password = c.String(),
                        EncodedMustUnderstand = c.String(),
                        EncodedMustUnderstand12 = c.String(),
                        MustUnderstand = c.Boolean(nullable: false),
                        Actor = c.String(),
                        Role = c.String(),
                        DidUnderstand = c.Boolean(nullable: false),
                        EncodedRelay = c.String(),
                        Relay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Users", "Nick", c => c.String());
            DropColumn("dbo.Users", "login");
            DropColumn("dbo.Users", "password");
            DropColumn("dbo.Users", "EncodedMustUnderstand");
            DropColumn("dbo.Users", "EncodedMustUnderstand12");
            DropColumn("dbo.Users", "MustUnderstand");
            DropColumn("dbo.Users", "Actor");
            DropColumn("dbo.Users", "Role");
            DropColumn("dbo.Users", "DidUnderstand");
            DropColumn("dbo.Users", "EncodedRelay");
            DropColumn("dbo.Users", "Relay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Relay", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "EncodedRelay", c => c.String());
            AddColumn("dbo.Users", "DidUnderstand", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Role", c => c.String());
            AddColumn("dbo.Users", "Actor", c => c.String());
            AddColumn("dbo.Users", "MustUnderstand", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "EncodedMustUnderstand12", c => c.String());
            AddColumn("dbo.Users", "EncodedMustUnderstand", c => c.String());
            AddColumn("dbo.Users", "password", c => c.String());
            AddColumn("dbo.Users", "login", c => c.String());
            DropColumn("dbo.Users", "Nick");
            DropTable("dbo.Accounts");
        }
    }
}
