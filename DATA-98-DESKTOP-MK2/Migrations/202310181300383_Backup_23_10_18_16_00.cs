namespace DATA_98_DESKTOP_MK2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Backup_23_10_18_16_00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data98Users", "MarginPercent", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data98Users", "MarginPercent");
        }
    }
}
