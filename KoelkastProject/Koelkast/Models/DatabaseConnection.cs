using System.Data.Entity;

namespace Koelkast.Models
{
    /// <summary>
    /// Sets up a SQL connection to a SQL server database and creates the defined DbSets as tables
    /// </summary>
    public class TmDbContext : DbContext
    {
        //public DbSet<test> Tests { get; set; }
    }

    /// <summary>
    /// Sets up a MySQL connection to a database and creates the defined DbSets as tables
    /// </summary>
   
    public class MySQL : DbContext
    {
        // used to define relationships between Models
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // defines one to many relation between User and Fridge
            modelBuilder.Entity<User>()
                .HasMany(f => f.Fridges)
                .WithRequired(u => u.User);

            // defines one to many relation between User and Recipe
            modelBuilder.Entity<User>()
                .HasMany(r => r.Recipes)
                .WithRequired(u => u.User);

            // defines one to many relation between Fridge and Fridge_Ingredient_Amount
            modelBuilder.Entity<Fridge>()
                .HasMany(fia => fia.Ingredients)
                .WithRequired(f => f.Fridge);

            // defines one to many relation between Recipe and Step
            modelBuilder.Entity<Recipe>()
                .HasMany(s => s.Steps)
                .WithRequired(r => r.Recipe);

            // defines one to many relation between Recipe and Recipe_Ingredient_Amount
            modelBuilder.Entity<Recipe>()
                .HasMany(ria => ria.Ingredients)
                .WithRequired(r => r.Recipe);

            // defines one to many relation between Ingredient and Fridge_Ingredient_Amount
            modelBuilder.Entity<Ingredient>()
                .HasMany(fia => fia.FridgeIngredientAmounts)
                .WithRequired(i => i.Ingredient);

            // defines one to many relation between Ingredient and Recipe_Ingredient_Amount
            modelBuilder.Entity<Ingredient>()
                .HasMany(ria => ria.RecipeIngredientAmounts)
                .WithRequired(i => i.Ingredient);
        }

        //add DbSets here eg. public DbSet<User> Users { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Recipe_Ingredient_Amount> RecipeIngredientAmounts { get; set; }
        public DbSet<Fridge_Ingredient_Amount> FridgeIngredientAmounts { get; set; }
    }
}