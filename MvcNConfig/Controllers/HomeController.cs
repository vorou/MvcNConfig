using System.Configuration;
using System.Web.Mvc;

namespace MvcNConfig.Controllers
{
    public class HomeController : Controller
    {
        // compilation error
        public ActionResult Index()
        {
            var appSetting = ConfigurationManager.AppSettings["name"];
            return View((object) appSetting);
        }

        // works ok
        public string ConfigName()
        {
            return ConfigurationManager.AppSettings["name"];
        }
    }
}