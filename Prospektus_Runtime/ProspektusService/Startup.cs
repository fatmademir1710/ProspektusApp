using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProspektusService.Startup))]

namespace ProspektusService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}