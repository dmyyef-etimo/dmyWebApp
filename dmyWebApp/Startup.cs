using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dmyWebApp.Startup))]
namespace dmyWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
