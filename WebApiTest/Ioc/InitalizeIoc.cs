using System.Web;
using Microsoft.Practices.Unity;
using WebApiTest.Controllers;
using WebApiTest.Service;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Ioc
{
    public class InitalizeIoc
    {
        public static IUnityContainer GetContainer()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICustomerService>(new InjectionFactory(container =>
            {
                var requestUrl = HttpContext.Current.Request.Url;
                if(requestUrl.ToString().ToLower().Contains("audit"))
                    return new CustomerServiceFake();

                return new CustomerService();
            }));
            return unityContainer;
        }
    }
}