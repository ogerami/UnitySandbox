using System.Collections.Generic;
using WebApiTest.Models;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Service
{
    public class CustomerServiceFake : ICustomerService
    {
        public List<CustomerModel> GetCustomers()
        {
            return new List<CustomerModel>
            {
                new CustomerModel("customer 1 Fake", "123 test street Fake."),
                new CustomerModel("customer 2 Fake", "456 test street Fake.")
            };
        }
    }
}