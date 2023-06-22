namespace Magazin2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Greensmdf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vegetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        price = c.Int(nullable: false),
                        typeId = c.Int(nullable: false),
                        vegetableType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VegetableTypes", t => t.vegetableType_Id)
                .Index(t => t.vegetableType_Id);
            
            CreateTable(
                "dbo.VegetableTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegetables", "vegetableType_Id", "dbo.VegetableTypes");
            DropIndex("dbo.Vegetables", new[] { "vegetableType_Id" });
            DropTable("dbo.VegetableTypes");
            DropTable("dbo.Vegetables");
        }
    }
}
