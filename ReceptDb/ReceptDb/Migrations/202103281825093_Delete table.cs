namespace ReceptDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deletetable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ListUnits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ListUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
