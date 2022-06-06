namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UpdateTestimo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Testimonials", "TestimoComment", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Testimonials", "TestimoComment", c => c.String(maxLength: 150));
        }
    }
}
