using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMarkupMin.AspNet4.Common;
using JavaScriptEngineSwitcher.Core;

namespace WebAppVueWebpack
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);         
            JsEngineSwitcherConfig.Configure(JsEngineSwitcher.Instance);
            WebMarkupMinConfig.Configure(WebMarkupMinConfiguration.Instance);
        }

        //protected void Application_EndRequest()
        //{
        //    Response.AddHeader("X-UA-Compatible", "IE=edge,chrome=1");
        //}
    }
}
