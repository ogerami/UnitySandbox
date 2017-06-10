using System.Web.Http;
using Owin;
using WebApiTest.Ioc;

namespace WebApiTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.DependencyResolver = new UnityResolver(InitalizeIoc.GetContainer());
            app.UseWebApi(config);
        }
    }
}