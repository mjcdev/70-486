using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcExamDemo.Models
{
    public class CustomModelBinderModel
    {
        [Display(Name = "Name")]
        public string CustomName { get; set; }

        [Display(Name = "Description")]
        public string CustomDescription { get; set; }
    }
}
