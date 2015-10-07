using System.Net.Http.Headers;
using System.Web.Http;

namespace Mcs.Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
               name: "ActiveOrders",
               routeTemplate: "api/{controller}/active/{deviceId}"
           );

            config.Routes.MapHttpRoute(
                name: "PlaceRelatedAction",
                routeTemplate: "api/{controller}/place/{placeId}"
            );

            config.Routes.MapHttpRoute(
                name: "CategoryRelatedAction",
                routeTemplate: "api/{controller}/category/{categoryId}"
            );

            config.Routes.MapHttpRoute(
               name: "DeviceId",
               routeTemplate: "api/{controller}/deviceid/{deviceNumber}"
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ImagesApi",
                routeTemplate: "api/image/{controllerName}/{size}/{id}",
                defaults: new { controller = "images" }
            );

            config.Properties["api_url"] = "http://localhost/v1/";
        }
    }
}