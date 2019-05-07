using System.Data.Entity;

namespace Koelkast.Models
{
    public class tmDbContext : DbContext
    {
        public DbSet<test> Tests { get; set; }
    }

    public class MySQL : DbContext
    {
        public DbSet<test> Tests { get; set; }
    }
}