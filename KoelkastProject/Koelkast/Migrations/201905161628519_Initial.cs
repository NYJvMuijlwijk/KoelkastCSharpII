namespace Koelkast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fridge_Ingredient_Amount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Fridge_Id = c.Int(nullable: false),
                        Ingredient_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fridges", t => t.Fridge_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id, cascadeDelete: true)
                .Index(t => t.Fridge_Id)
                .Index(t => t.Ingredient_Id);
            
            CreateTable(
                "dbo.Fridges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
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
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                        Name = c.String(nullable: false, unicode: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Recipe_Ingredient_Amount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Ingredient_Id = c.Int(nullable: false),
                        Recipe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Recipe_Id);
            
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
                "dbo.Steps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, unicode: false),
                        StepDescription = c.String(nullable: false, unicode: false),
                        Recipe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Recipe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Steps", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipe_Ingredient_Amount", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipe_Ingredient_Amount", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Fridge_Ingredient_Amount", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Fridges", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Fridge_Ingredient_Amount", "Fridge_Id", "dbo.Fridges");
            DropIndex("dbo.Steps", new[] { "Recipe_Id" });
            DropIndex("dbo.Recipe_Ingredient_Amount", new[] { "Recipe_Id" });
            DropIndex("dbo.Recipe_Ingredient_Amount", new[] { "Ingredient_Id" });
            DropIndex("dbo.Recipes", new[] { "User_Id" });
            DropIndex("dbo.Fridges", new[] { "User_Id" });
            DropIndex("dbo.Fridge_Ingredient_Amount", new[] { "Ingredient_Id" });
            DropIndex("dbo.Fridge_Ingredient_Amount", new[] { "Fridge_Id" });
            DropTable("dbo.Steps");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Recipe_Ingredient_Amount");
            DropTable("dbo.Recipes");
            DropTable("dbo.Users");
            DropTable("dbo.Fridges");
            DropTable("dbo.Fridge_Ingredient_Amount");
        }
    }
}
