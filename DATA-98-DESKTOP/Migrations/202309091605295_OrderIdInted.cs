﻿namespace DATA_98_DESKTOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderIdInted : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", "Id");
        }
    }
}
