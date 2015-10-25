using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcExamDemo.Models.Binders
{
    public class CustomModelBinderModelCustomBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //get the Request
            HttpRequestBase request = controllerContext.HttpContext.Request;

            //get the Data
            string customName = request.Form.Get("CustomName");
            string customDescription = request.Form.Get("CustomDescription");

            //return Model to the Controller
            return new CustomModelBinderModel
            {
                CustomName = customName,
                CustomDescription = customDescription
            };
        }
    }
}
