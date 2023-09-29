namespace DATA_98_DESKTOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FaultTypeStringified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ItemName", c => c.String());
            AddColumn("dbo.Orders", "FaultName", c => c.String());
            DropColumn("dbo.Orders", "FaultType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "FaultType", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "FaultName");
            DropColumn("dbo.Orders", "ItemName");
        }
    }
}
