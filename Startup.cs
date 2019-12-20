using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RestaurantApplication3.Web.Startup))]
namespace RestaurantApplication3.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Hangfire.ConfigureHangfire(app);
            Hangfire.InitializeJobs();
        }
    }
}
