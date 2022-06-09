namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_deleteAdminStatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Status", c => c.Boolean(nullable: false));
        }
    }
}
