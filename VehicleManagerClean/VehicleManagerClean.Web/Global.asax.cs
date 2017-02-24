using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using VehicleManagerClean.Core.Infrastructure;
using VehicleManagerClean.Core.Repository;
using VehicleManagerClean.Data.Infrastructure;
using VehicleManagerClean.Data.Repository;

namespace VehicleManagerClean.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //var container = new Container();

            //container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //container.Register<IDatabaseFactory, DatabaseFactory>(Lifestyle.Scoped);
            //container.Register<IVehicleRepository, VehicleRepository>();
            //container.Register<IUnitOfWork, UnitOfWork>();

            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //container.Verify();

            //DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
