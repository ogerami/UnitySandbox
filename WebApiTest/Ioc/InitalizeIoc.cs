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
            unityContainer.RegisterType<ICustomerSearchService, CustomerSearchService>();
            unityContainer.RegisterType<ICustomerService>(new InjectionFactory(container => new CustomerService()));
            return unityContainer;
        }
    }
}