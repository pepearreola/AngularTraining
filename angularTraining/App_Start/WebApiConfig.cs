using System.Web.Http;

namespace angularTraining
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RestaurantRequest",
                routeTemplate: "api/restaurants/{restaurantId}",
                defaults: new { controller = "Restaurants" },
                constraints: null
            );

            config.Routes.MapHttpRoute(
                name: "RestaurantsRequest",
                routeTemplate: "api/restaurants",
                defaults: new { controller = "Restaurants" },
                constraints: null
            );
        }
    }
}
