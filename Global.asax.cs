using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RegistroCliente.Models.ModelClass;

namespace RegistroCliente
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //using (var context = new RegistroClienteEntities())
            //{
            //    var banco = new NBanco()
            //    {
            //        nombre = "banco1",
            //        siglas = "BCB"
            //    };
            //    context.NBanco.Add(banco);
            //    context.SaveChanges();
            //}
        }

        protected void Application_EndRequest()
        {
            var error = this.Context.AllErrors; //here breakpoint 
            // under debug mode you can find the exceptions at code: this.Context.AllErrors 
        } 

        

    }
}
