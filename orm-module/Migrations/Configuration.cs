using orm_module.Entities;

namespace orm_module.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<orm_module.Entities.Northwind>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Northwind context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                new Category() { CategoryName = "Cat1" },
                new Category() { CategoryName = "Cat2" },
                new Category() { CategoryName = "Cat3" });

            context.Regions.AddOrUpdate(
                r => r.RegionID,
                new Region() { RegionID = 1, RegionDescription = "RegDescr1" },
                new Region() { RegionID = 2, RegionDescription = "RegDescr2" },
                new Region() { RegionID = 3, RegionDescription = "RegDescr3" });

            context.Territories.AddOrUpdate(
                t => t.TerritoryID,
                new Territory() { TerritoryID = "terid1", TerritoryDescription = "descr1", RegionID = 1 },
                new Territory() { TerritoryID = "terid2", TerritoryDescription = "descr2", RegionID = 1 },
                new Territory() { TerritoryID = "terid3", TerritoryDescription = "descr5", RegionID = 3 });
        }
    }
}
