namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_ExperienceInfo_ContactLink_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactLinks",
                c => new
                    {
                        LinkId = c.Int(nullable: false, identity: true),
                        LinkName = c.String(maxLength: 30),
                        LinkUrl = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.LinkId);
            
            CreateTable(
                "dbo.ExperienceInfoes",
                c => new
                    {
                        ExperienceId = c.Int(nullable: false, identity: true),
                        ExperienceHeading = c.String(maxLength: 50),
                        ExperienceDescription = c.String(maxLength: 200),
                        ExperienceSumaryHead = c.String(maxLength: 50),
                        ExperienceTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExperienceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExperienceInfoes");
            DropTable("dbo.ContactLinks");
        }
    }
}
