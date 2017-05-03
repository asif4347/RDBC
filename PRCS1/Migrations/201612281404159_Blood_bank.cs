namespace PRCS1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blood_bank : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodBankTests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        Result = c.String(),
                        isDelivered = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BloodBankTests");
        }
    }
}