using System.Data.Entity;

namespace Koelkast.Models
{
    /// <summary>
    /// Sets up a SQL connection to a SQL server database and creates the defined DbSets as tables
    /// </summary>
    public class tmDbContext : DbContext
    {
        //public DbSet<test> Tests { get; set; }
    }

    /// <summary>
    /// Sets up a MySQL connection to a database and creates the defined DbSets as tables
    /// </summary>
   
    public class MySQL : DbContext
    {
        //add DbSets here eg.
        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Fridge_Ingredient> Fridge_Ingredients { get; set; }
        public DbSet<Recipe_Ingredient> Recipe_Ingredients { get; set; }
        public DbSet<Recipe_Step> Recipe_Steps { get; set; }
    }
}