using MvcTestsApi.Configs;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcTestsApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            AutoMapperConfig.Initialize();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterWebApiFilters(GlobalConfiguration.Configuration.Filters);

            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            
        }
    }
}