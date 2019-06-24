namespace DatatablesCodefirstResponsive.Migrations
{
    using DataTablesWithResponsive.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataTablesWithResponsive.Models.StudentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataTablesWithResponsive.Models.StudentDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (!context.students.Any())
            {
                Random rr = new Random();
                List<Students> s = new List<Students>();
                for (int i = 1; i <= 4000; i++)
                {

                    int h = rr.Next(6);
                    int S = rr.Next(1, 13);
                    s.Add(new Students { Name = "T" + i, STD = S.ToString(),Hobies = h  });
                }
                context.students.AddRange(s);
                context.SaveChanges();
            }
            if (!context.hobbies.Any())
            {
                context.hobbies.AddOrUpdate(r => r.idhobbies,
                                    new Models.hobbies() { hobbiesName= "Walking" , idhobbies = 1},
                                    new Models.hobbies() { hobbiesName = "Exercise", idhobbies = 2 },
                                    new Models.hobbies() { hobbiesName = "Running", idhobbies = 3 },
                                    new Models.hobbies() { hobbiesName = "Tennis", idhobbies = 4 },
                                    new Models.hobbies() { hobbiesName = "Bicycling", idhobbies = 5 });
            }
        }
    }
}
