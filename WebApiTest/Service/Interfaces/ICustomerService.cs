using System.Collections.Generic;
using WebApiTest.Models;

namespace WebApiTest.Service.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerModel> GetCustomers();
    }
}