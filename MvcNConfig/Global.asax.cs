using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NConfig;

namespace MvcNConfig
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            NConfigurator.UsingFile("Local.config").SetAsSystemDefault();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}