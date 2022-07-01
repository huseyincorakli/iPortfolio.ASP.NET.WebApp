namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UpdatePerson1822 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "PersonJob", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "PersonExperience", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PersonExperience", c => c.String(maxLength: 30));
            AlterColumn("dbo.People", "PersonJob", c => c.String(maxLength: 20));
        }
    }
}
