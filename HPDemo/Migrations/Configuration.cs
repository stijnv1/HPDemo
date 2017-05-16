namespace HPDemo.Migrations
{
    using HPDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HPDemo.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HPDemo.Models.MovieDBContext";
        }

        protected override void Seed(HPDemo.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var Movies = new List<Movie>
            {
              new Movie
              {
                  ID = 1,
                  Title = "Pulp Fiction",
                  ReleaseDate = DateTime.Parse("1994-11-11"),
                  Genre = "Crime"
              },
              new Movie
              {
                  ID = 2,
                  Title = "Resevoir Dogs",
                  ReleaseDate = DateTime.Parse("1992-09-02"),
                  Genre = "Crime"
              }
            };

            Movies.ForEach(m => context.Movies.AddOrUpdate(t => t.Title, m));
            context.SaveChanges();
        }
    }
}
