namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial24 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodCampusInfoes", "NoOfBagsDay3", c => c.Int(nullable: false));
            AddColumn("dbo.BloodCampusInfoes", "NoOfBagsDay4", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodCampusInfoes", "NoOfBagsDay4");
            DropColumn("dbo.BloodCampusInfoes", "NoOfBagsDay3");
        }
    }
}
