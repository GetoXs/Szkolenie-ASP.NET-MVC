﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicStore
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "HomeSpecial",
				url: "Home/Index/{param}/{next}",
				defaults: new { controller = "Home", action = "Index", next = DateTime.Now }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Songs", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
