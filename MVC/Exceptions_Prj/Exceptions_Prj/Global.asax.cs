using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Exceptions_Prj.App_Start;

namespace Exceptions_Prj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // GlobalFilters.Filters.Add(new HandleErrorAttribute());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
