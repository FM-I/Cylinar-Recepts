namespace ReceptDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Single(nullable: false),
                        UnitId = c.Int(nullable: false),
                        ReceptId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Recepts", t => t.ReceptId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId)
                .Index(t => t.ReceptId);
            
            CreateTable(
                "dbo.Recepts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ReceptTypeId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ReceptTypes", t => t.ReceptTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ReceptTypeId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ReceptTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Recepts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Recepts", "ReceptTypeId", "dbo.ReceptTypes");
            DropForeignKey("dbo.Ingredients", "ReceptId", "dbo.Recepts");
            DropIndex("dbo.Recepts", new[] { "UserId" });
            DropIndex("dbo.Recepts", new[] { "ReceptTypeId" });
            DropIndex("dbo.Ingredients", new[] { "ReceptId" });
            DropIndex("dbo.Ingredients", new[] { "UnitId" });
            DropTable("dbo.Units");
            DropTable("dbo.Users");
            DropTable("dbo.ReceptTypes");
            DropTable("dbo.Recepts");
            DropTable("dbo.Ingredients");
        }
    }
}
