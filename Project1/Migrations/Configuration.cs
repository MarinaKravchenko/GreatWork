namespace Project1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project1.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Project1.Context context)
        {
            context.Singers.AddOrUpdate(
              p => p.Name,
              new Singer { Name = "Andrew Peters" },
              new Singer { Name = "Brice Lambson" },
              new Singer { Name = "Rowan Miller" }
            );

            context.SaveChanges();

            context.Songs.AddOrUpdate(
               p => p.Name,
               new Song { Name = "Bird", Singer = context.Singers.Single( s => s.Name == "Andrew Peters" ) },
               new Song { Name = "Wild wind", Singer = context.Singers.Single(s => s.Name == "Brice Lambson") },
               new Song { Name = "Nature", Singer = context.Singers.Single(s => s.Name == "Rowan Miller") },
               new Song { Name = "Sounds", Singer = context.Singers.Single( s => s.Name == "Andrew Peters" ) },
               new Song { Name = "Today", Singer = context.Singers.Single(s => s.Name == "Brice Lambson") },
               new Song { Name = "Rising sun", Singer = context.Singers.Single(s => s.Name == "Brice Lambson") }
             );

            context.SaveChanges();
        }
    }
}
