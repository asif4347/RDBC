namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial23 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomotologyLabs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        Result = c.String(),
                        isDelivered = c.String(),
                        ReferedBy = c.String(),
                        TestRequested = c.String(),
                        Payment = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        Result = c.String(),
                        isDelivered = c.String(),
                        ReferedBy = c.String(),
                        TestRequested = c.String(),
                        Payment = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoutineChemistryLabs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        Result = c.String(),
                        isDelivered = c.String(),
                        ReferedBy = c.String(),
                        TestRequested = c.String(),
                        Payment = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SpecialChemistryLabs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        Result = c.String(),
                        isDelivered = c.String(),
                        ReferedBy = c.String(),
                        TestRequested = c.String(),
                        Payment = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.BloodBankTests", "HBsAg", c => c.String(nullable: false));
            AddColumn("dbo.BloodBankTests", "HCV", c => c.String(nullable: false));
            AddColumn("dbo.BloodBankTests", "HIV", c => c.String(nullable: false));
            AddColumn("dbo.BloodBankTests", "Syphilis", c => c.String(nullable: false));
            AddColumn("dbo.BloodBankTests", "Malaria", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodBankTests", "Malaria");
            DropColumn("dbo.BloodBankTests", "Syphilis");
            DropColumn("dbo.BloodBankTests", "HIV");
            DropColumn("dbo.BloodBankTests", "HCV");
            DropColumn("dbo.BloodBankTests", "HBsAg");
            DropTable("dbo.SpecialChemistryLabs");
            DropTable("dbo.RoutineChemistryLabs");
            DropTable("dbo.Patients");
            DropTable("dbo.HomotologyLabs");
        }
    }
}
