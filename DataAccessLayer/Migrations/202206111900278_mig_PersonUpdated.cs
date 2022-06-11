namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_PersonUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "PersonAboutBody", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PersonAboutBody", c => c.String(maxLength: 150));
        }
    }
}
