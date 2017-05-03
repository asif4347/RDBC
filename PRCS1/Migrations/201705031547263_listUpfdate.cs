namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class listUpfdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodBankTests", "ReferedBy", c => c.String());
            AddColumn("dbo.BloodBankTests", "TestRequested", c => c.String());
            AddColumn("dbo.BloodBankTests", "Payment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodBankTests", "Payment");
            DropColumn("dbo.BloodBankTests", "TestRequested");
            DropColumn("dbo.BloodBankTests", "ReferedBy");
        }
    }
}
