namespace Koelkast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecipeDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Description", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "Description");
        }
    }
}
