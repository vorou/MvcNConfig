using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcNConfig.Startup))]
namespace MvcNConfig
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
