namespace DATA_98_DESKTOP_MK2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Backup_23_10_18_15_54 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Data98Users", "MarginPercent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Data98Users", "MarginPercent", c => c.Double(nullable: false));
        }
    }
}
