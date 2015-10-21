using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcExamDemo.Models
{
    public class LocalDbInitializer : DropCreateDatabaseAlways<LocalDbContext>
    {
        protected override void Seed(LocalDbContext context)
        {
            base.Seed(context);

            var countries = new List<Country>
            {
                new Country
                {
                    Name = "England"
                },
                new Country
                {
                    Name = "Scotland"
                },
                new Country
                {
                    Name = "Wales"
                }
            };

            countries.ForEach(c => context.Countries.Add(c));
            context.SaveChanges();

            var cities = new List<City>
            {
                new City
                {
                    Name = "London",
                    AverageSalary = 123456.78,
                    CountryId = countries.Single(c => c.Name == "England").CountryId
                },
                new City
                {
                    Name = "Birmingham",
                    AverageSalary = 12345.67,
                    CountryId = countries.Single(c => c.Name == "England").CountryId
                },
                new City
                {
                    Name = "Cardiff",
                    AverageSalary = 1234.56,
                    CountryId = countries.Single(c => c.Name == "Wales").CountryId
                },
                new City
                {
                    Name = "Glasgow",
                    AverageSalary = 123.45,
                    CountryId = countries.Single(c => c.Name == "Scotland").CountryId
                }
            };

            cities.ForEach(c => context.Cities.Add(c));
            context.SaveChanges();
        }
    }
}
