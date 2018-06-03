using Autofac;
using Autofac.Integration.Mvc;
using FT.Data;
using FT.Services;
using FT.Services.Services;
using System.Web.Http;
using System.Web.Mvc;

namespace FT.Api.Config
{
    public static class AutofacConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);

            builder.RegisterType<FTContext>().InstancePerLifetimeScope().AsSelf();

            //Register service HERE 
            builder.RegisterType<TaskService>().AsSelf();
            builder.RegisterType<UserService>().AsSelf();
            builder.RegisterType<TaskCommentsService>().AsSelf();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}