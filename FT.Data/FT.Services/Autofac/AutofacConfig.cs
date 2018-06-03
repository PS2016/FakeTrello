using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace FT.Services.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
          
            var builder = new ContainerBuilder();

          
        

           
            var container = builder.Build();

           
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
