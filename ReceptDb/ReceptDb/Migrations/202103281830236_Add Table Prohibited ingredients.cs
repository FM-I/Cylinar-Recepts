namespace ReceptDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableProhibitedingredients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProhibitedIngredients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProhibitedIngredients");
        }
    }
}
