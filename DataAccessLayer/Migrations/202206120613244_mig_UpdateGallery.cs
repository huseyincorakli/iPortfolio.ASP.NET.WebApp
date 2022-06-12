namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UpdateGallery : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Galleries", "ImageUrl", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Galleries", "ImageUrl", c => c.String(maxLength: 100));
        }
    }
}
