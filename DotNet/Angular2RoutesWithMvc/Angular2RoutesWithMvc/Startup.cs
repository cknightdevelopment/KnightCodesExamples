using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2RoutesWithMvc.Startup))]
namespace Angular2RoutesWithMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
