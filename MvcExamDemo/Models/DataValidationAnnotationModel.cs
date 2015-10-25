using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcExamDemo.Models
{
    public class DataValidationAnnotationModel
    {
        [Required]
        public string RequiredProperty { get; set; }

        [MustBeOneOrTwo(ErrorMessage = "Input must be 1 or 2")]
        public int IntInput { get; set; }
    }

    public class MustBeOneOrTwoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return new[] { 1, 2 }.Contains((int)value);
        }
    }
}
