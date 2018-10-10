using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTests
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{index}",
                defaults: new { controller = "invitationdigital", action = "tests", index = UrlParameter.Optional }
            );
        }
    }
}
