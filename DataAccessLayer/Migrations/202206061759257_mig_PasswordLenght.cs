namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_PasswordLenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "Password", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "Password", c => c.String(maxLength: 30));
        }
    }
}
