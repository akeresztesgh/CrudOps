namespace CrudOps.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CrudOps.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CrudOps.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            for(int i=0; i<10; i++)
            {
                context.MyStuff.AddOrUpdate(x => x.Prop2, new Models.Stuff() { Prop1 = $"Prop1-{i}", Prop2=i });
            }
            
        }
    }
}
