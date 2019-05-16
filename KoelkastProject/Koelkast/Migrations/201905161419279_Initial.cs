namespace Koelkast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fridge_Ingredient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Fridge_Id = c.Int(),
                        Ingredient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fridges", t => t.Fridge_Id)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id)
                .Index(t => t.Fridge_Id)
                .Index(t => t.Ingredient_Id);
            
            CreateTable(
                "dbo.Fridges",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        E_mail = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, unicode: false),
                        Unit_Of_Measure = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipe_Ingredient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Ingredient_Id = c.Int(),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.Recipe_Step",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Recipe_Id = c.Int(),
                        Step_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .ForeignKey("dbo.Steps", t => t.Step_Id)
                .Index(t => t.Recipe_Id)
                .Index(t => t.Step_Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                        Name = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, unicode: false),
                        Step_description = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipe_Step", "Step_Id", "dbo.Steps");
            DropForeignKey("dbo.Recipe_Step", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipe_Ingredient", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipe_Ingredient", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Fridge_Ingredient", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Fridges", "Id", "dbo.Users");
            DropForeignKey("dbo.Fridge_Ingredient", "Fridge_Id", "dbo.Fridges");
            DropIndex("dbo.Recipe_Step", new[] { "Step_Id" });
            DropIndex("dbo.Recipe_Step", new[] { "Recipe_Id" });
            DropIndex("dbo.Recipe_Ingredient", new[] { "Recipe_Id" });
            DropIndex("dbo.Recipe_Ingredient", new[] { "Ingredient_Id" });
            DropIndex("dbo.Fridges", new[] { "Id" });
            DropIndex("dbo.Fridge_Ingredient", new[] { "Ingredient_Id" });
            DropIndex("dbo.Fridge_Ingredient", new[] { "Fridge_Id" });
            DropTable("dbo.Steps");
            DropTable("dbo.Recipes");
            DropTable("dbo.Recipe_Step");
            DropTable("dbo.Recipe_Ingredient");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Users");
            DropTable("dbo.Fridges");
            DropTable("dbo.Fridge_Ingredient");
        }
    }
}
