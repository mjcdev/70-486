using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MvcExamDemo.Models
{
    public class DynamicCacheDemo
    {
        public static string RenderItem(HttpContext context)
        {
            var itemsList = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4"
            };
            var random = new Random();

            return itemsList[random.Next(itemsList.Count - 1)];
        }
    }
}
