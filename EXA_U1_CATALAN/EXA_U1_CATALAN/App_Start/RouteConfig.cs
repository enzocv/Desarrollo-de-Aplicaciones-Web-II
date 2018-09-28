using System.Web.Mvc;
using System.Web.Routing;

namespace EXA_U1_CATALAN
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Carga", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}