namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_delete : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EducationInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EducationInfoes",
                c => new
                    {
                        EduInfoId = c.Int(nullable: false, identity: true),
                        EduHeading = c.String(maxLength: 50),
                        EduDescription = c.String(maxLength: 200),
                        EduSumaryHead = c.String(maxLength: 50),
                        EduTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EduInfoId);
            
        }
    }
}
