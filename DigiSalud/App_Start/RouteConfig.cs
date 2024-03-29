﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DigiSalud
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cliente", action = "Ingresar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Formulario",
                url: "{controller}/{id}",
                defaults: new { controller = "Formulario", action = "Formulario" }
            );

            routes.MapRoute(
                name: "Detalle",
                url: "{controller}/{id}",
                defaults: new { controller = "Detalle", action = "Detalle" }
            );
            routes.MapRoute(
                name: "Grafica",
                url: "{controller}/{id}",
                defaults: new { controller = "Grafica", action = "Grafica" }
            );
        }
    }
}
