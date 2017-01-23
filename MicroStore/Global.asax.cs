using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
//Para iniciar la base de datos
using System.Data.Entity;

namespace MicroStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Es para indicarle que ya tenemos una base datos existente
            Database.SetInitializer<MicroStore.Models.OurDbContext>(null);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
