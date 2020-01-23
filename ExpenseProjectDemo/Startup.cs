using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpenseProjectDemo.Startup))]
namespace ExpenseProjectDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
