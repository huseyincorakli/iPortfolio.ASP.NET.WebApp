namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UpdateSkill : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Skills", "SkillAbaout");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Skills", "SkillAbaout", c => c.String(maxLength: 200));
        }
    }
}
