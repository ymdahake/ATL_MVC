namespace ATL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedUserSubscriptionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBookSubscriptions",
                c => new
                    {
                        UserBookSubscriptionId = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false),
                        BookId = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserBookSubscriptionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserBookSubscriptions");
        }
    }
}
