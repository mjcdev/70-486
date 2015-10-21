using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcExamDemo.Models
{
    public class LocalDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }
    }

    [Table("Country")]
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }

        [Display(Name = "Country Name")] 
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }

    [Table("City")]
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }

        [Display(Name = "City Name")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double? AverageSalary { get; set; }

        [Display(Name = "Country Id")]
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
