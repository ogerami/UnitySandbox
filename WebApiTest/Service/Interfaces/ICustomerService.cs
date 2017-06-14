using System.Collections.Generic;
using WebApiTest.Models;

namespace WebApiTest.Service.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerModel> GetCustomers();
        List<CustomerModel> GetCustomersByName(string name);
        List<CustomerModel> GetCustomersByAddress(string address);
        List<CustomerModel> GetCustomersByNameAndAddress(string name, string address);
    }
}