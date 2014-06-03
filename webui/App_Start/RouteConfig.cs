using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Polymermvc
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
        name: "EditPerson",
        url: "people/edit/{recordid}",
        defaults: new { controller = "People", action = "Edit" }
      );

      routes.MapRoute(
        name: "PersonInfo",
        url: "people/info/{recordid}",
        defaults: new { controller = "People", action = "Info" }
      );

      routes.MapRoute(
        name: "PersonJsonInfo",
        url: "people/jsoninfo/{recordid}",
        defaults: new { controller = "People", action = "JsonInfo" }
      );

      routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}