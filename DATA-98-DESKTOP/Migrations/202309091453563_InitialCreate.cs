namespace DATA_98_DESKTOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderDesc = c.String(),
                        FaultType = c.Int(nullable: false),
                        DiagDesc = c.String(),
                        FixPrice = c.Double(nullable: false),
                        Conclusion = c.String(),
                        ApprovalPhase = c.Int(nullable: false),
                        MediaArray = c.String(),
                        MasterId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
