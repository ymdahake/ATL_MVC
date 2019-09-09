namespace ATL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedConstraintsToModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Language_LanguageId", "dbo.Languages");
            DropIndex("dbo.Books", new[] { "Language_LanguageId" });
            AddColumn("dbo.Books", "Language", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Authors", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Books", "ISBN", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
            DropColumn("dbo.Books", "LanguageId");
            DropColumn("dbo.Books", "Language_LanguageId");
            DropTable("dbo.Languages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            AddColumn("dbo.Books", "Language_LanguageId", c => c.Int());
            AddColumn("dbo.Books", "LanguageId", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Books", "ISBN", c => c.String());
            AlterColumn("dbo.Books", "Description", c => c.String());
            AlterColumn("dbo.Books", "Authors", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
            DropColumn("dbo.Books", "Language");
            CreateIndex("dbo.Books", "Language_LanguageId");
            AddForeignKey("dbo.Books", "Language_LanguageId", "dbo.Languages", "LanguageId");
        }
    }
}
