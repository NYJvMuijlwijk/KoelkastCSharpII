namespace Koelkast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModelsFridgeIngredient : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Fridges");
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
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, unicode: false),
                        Unit_Of_Measure = c.String(nullable: false, unicode: false),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);
            
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
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);
            
            AddColumn("dbo.Fridges", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Fridges", "Id");
            DropColumn("dbo.Fridges", "Fridge_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fridges", "Fridge_Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Steps", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Ingredients", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Fridge_Ingredient", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Fridge_Ingredient", "Fridge_Id", "dbo.Fridges");
            DropIndex("dbo.Steps", new[] { "Recipe_Id" });
            DropIndex("dbo.Ingredients", new[] { "Recipe_Id" });
            DropIndex("dbo.Fridge_Ingredient", new[] { "Ingredient_Id" });
            DropIndex("dbo.Fridge_Ingredient", new[] { "Fridge_Id" });
            DropPrimaryKey("dbo.Fridges");
            DropColumn("dbo.Fridges", "Id");
            DropTable("dbo.Steps");
            DropTable("dbo.Recipes");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Fridge_Ingredient");
            AddPrimaryKey("dbo.Fridges", "Fridge_Id");
        }
    }
}
