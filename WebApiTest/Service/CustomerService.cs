using System.Collections.Generic;
using WebApiTest.Models;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Service
{
    public class CustomerService : ICustomerService
    {
        public List<CustomerModel> GetCustomers()
        {
            return new List<CustomerModel>
            {
                new CustomerModel("customer 1", "123 test street."),
                new CustomerModel("customer 2", "456 test street.")
            };
        }
    }
}