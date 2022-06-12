namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UpdateContext : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EduInfos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EduInfos",
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
