namespace ReceptDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListUnitsandpropertiesUserRecept : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recepts", "Moderation", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "isAdmin", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Ingredients", "Name", c => c.String(maxLength: 35));
            AlterColumn("dbo.Recepts", "Name", c => c.String(maxLength: 100));
            AlterColumn("dbo.ReceptTypes", "Name", c => c.String(maxLength: 25));
            AlterColumn("dbo.Users", "Login", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 50));
            AlterColumn("dbo.Units", "Name", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Units", "Name", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Login", c => c.String());
            AlterColumn("dbo.ReceptTypes", "Name", c => c.String());
            AlterColumn("dbo.Recepts", "Name", c => c.String());
            AlterColumn("dbo.Ingredients", "Name", c => c.String());
            DropColumn("dbo.Users", "isAdmin");
            DropColumn("dbo.Recepts", "Moderation");
        }
    }
}
