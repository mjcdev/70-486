using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcExamDemo.Startup))]
namespace MvcExamDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
