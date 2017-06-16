using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MondayWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "helloworld",
            //    url: "hello/{action}/{controller}",
            //    defaults: new { controller = "Demo", action = "Index"}
            //);

            routes.MapRoute(
                name: "legal",
                url: "legal/{action}/{controller}/{id}",
                defaults: new { controller = "Demo", action = "Index" }
            );

            routes.MapRoute(
                name: "calculator",
                url: "calc/{action}/{x}/{y}",
                defaults: new {controller = "Demo"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
