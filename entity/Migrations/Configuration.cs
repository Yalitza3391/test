namespace entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<entity.Modelos.DBContextClass>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(entity.Modelos.DBContextClass context)
        {

            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.table1s.AddOrUpdate(
             p => p.IdT1,
            new Modelos.Table1{ IdT1=1, Name = "Andrew Peters" }
            
            );
           
        }
    }
}
