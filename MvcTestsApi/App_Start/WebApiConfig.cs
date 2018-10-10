using System.Web.Http;

namespace MvcTestsApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}"
               // defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "Default",
               routeTemplate: "{controller}/{action}",
               defaults: new { controller = "Values", action = "Get",}
           );

            config.EnableSystemDiagnosticsTracing();
        }
    }
}
