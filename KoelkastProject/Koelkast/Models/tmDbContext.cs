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
        public DbSet<User> users { get; set; }
        public DbSet<Fridge> fridges { get; set; }

    }
}