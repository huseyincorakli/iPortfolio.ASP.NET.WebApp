namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_PersonUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "FreelanceStatus", c => c.String(maxLength: 20));
            AddColumn("dbo.People", "PhotoUrl", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "PhotoUrl");
            DropColumn("dbo.People", "FreelanceStatus");
        }
    }
}
