using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace blog_web.test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { controller = "Blog", action = "List", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Blog", action = "List", id = UrlParameter.Optional });
            routes.MapRoute(null,
                "{category}",
            new {controller="Blog",action="List",page =1});
            routes.MapRoute(null, "{category}/Page{page}",
               new {controller ="Blog", action="List"},
               new {page=@"\d+"}
               );
            routes.MapRoute(null, "{controller}/{action}");

        }
    }
}
