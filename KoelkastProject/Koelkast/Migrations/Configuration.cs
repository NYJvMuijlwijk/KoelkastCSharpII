namespace Koelkast.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MySql.Data.MySqlClient;

    internal sealed class Configuration : DbMigrationsConfiguration<Koelkast.Models.MySQL>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            // set Sql generator for MySql database connection
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());

        }

        protected override void Seed(Koelkast.Models.MySQL context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
