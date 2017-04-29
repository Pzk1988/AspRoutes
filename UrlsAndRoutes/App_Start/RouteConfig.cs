using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "Gowno/{name}",
                defaults: new {controller = "Customer", action = "List", name = "defaultowe gowno" });

            routes.MapRoute(
                name: null,
                url: "{controller}/{action}/{name}",
                defaults: new { name = "cos" });

            routes.MapRoute(
                name: null,
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
