using FotoStudio.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FotoStudio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Database.SetInitializer<FotoStudioDB>(new DropCreateDatabaseAlways<FotoStudioDB>());
           // BLL.UserTypeBLL.Guardar();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Ventas", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
