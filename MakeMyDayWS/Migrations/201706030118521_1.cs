namespace MakeMyDayWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Icon = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        TimeInHours = c.Int(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Adres = c.String(),
                        IsPublic = c.Boolean(nullable: false),
                        Orgaznizer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Orgaznizer_ID)
                .Index(t => t.Orgaznizer_ID);
            
            CreateTable(
                "dbo.Users",
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
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User1_ID = c.Int(),
                        User2_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User1_ID)
                .ForeignKey("dbo.Users", t => t.User2_ID)
                .Index(t => t.User1_ID)
                .Index(t => t.User2_ID);
            
            CreateTable(
                "dbo.Invites",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Answer = c.Boolean(nullable: false),
                        Event_ID = c.Int(),
                        Invited_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Events", t => t.Event_ID)
                .ForeignKey("dbo.Users", t => t.Invited_ID)
                .Index(t => t.Event_ID)
                .Index(t => t.Invited_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invites", "Invited_ID", "dbo.Users");
            DropForeignKey("dbo.Invites", "Event_ID", "dbo.Events");
            DropForeignKey("dbo.Friends", "User2_ID", "dbo.Users");
            DropForeignKey("dbo.Friends", "User1_ID", "dbo.Users");
            DropForeignKey("dbo.Events", "Orgaznizer_ID", "dbo.Users");
            DropIndex("dbo.Invites", new[] { "Invited_ID" });
            DropIndex("dbo.Invites", new[] { "Event_ID" });
            DropIndex("dbo.Friends", new[] { "User2_ID" });
            DropIndex("dbo.Friends", new[] { "User1_ID" });
            DropIndex("dbo.Events", new[] { "Orgaznizer_ID" });
            DropTable("dbo.Invites");
            DropTable("dbo.Friends");
            DropTable("dbo.Users");
            DropTable("dbo.Events");
        }
    }
}
