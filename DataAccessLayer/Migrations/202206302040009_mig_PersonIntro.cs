namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_PersonIntro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Intro", c => c.String(maxLength: 400));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Intro");
        }
    }
}
