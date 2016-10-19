using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace RadyoAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // URL etc: "api/Record/Get/2"
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Added to response in JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);
             
            //Trace gloabal exceptions
            config.Services.Add(typeof(IExceptionLogger), new TraceExceptionLogger());

        }
    }
}
