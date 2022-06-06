namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UpdateInteraction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interactions", "InteractionName", c => c.String(maxLength: 20));
            AddColumn("dbo.Interactions", "InteractionValue", c => c.Int(nullable: false));
            AlterColumn("dbo.Interactions", "InteractionDiscription", c => c.String(maxLength: 50));
            DropColumn("dbo.Interactions", "HappyClients");
            DropColumn("dbo.Interactions", "CompletedProject");
            DropColumn("dbo.Interactions", "HourOfSupport");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interactions", "HourOfSupport", c => c.Int(nullable: false));
            AddColumn("dbo.Interactions", "CompletedProject", c => c.Int(nullable: false));
            AddColumn("dbo.Interactions", "HappyClients", c => c.Int(nullable: false));
            AlterColumn("dbo.Interactions", "InteractionDiscription", c => c.String(maxLength: 200));
            DropColumn("dbo.Interactions", "InteractionValue");
            DropColumn("dbo.Interactions", "InteractionName");
        }
    }
}
