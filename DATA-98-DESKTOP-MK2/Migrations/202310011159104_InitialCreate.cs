namespace DATA_98_DESKTOP_MK2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Data98Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        PassMD5 = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        RightsType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Data98Users");
        }
    }
}
