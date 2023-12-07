namespace DATA_98_DESKTOP_MK2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefusesExpandedWithOID : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Refuses", newName: "OrderRefuses");
            AddColumn("dbo.OrderRefuses", "OrderId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderRefuses", "OrderId");
            RenameTable(name: "dbo.OrderRefuses", newName: "Refuses");
        }
    }
}
