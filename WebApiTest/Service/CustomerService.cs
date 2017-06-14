using System.Collections.Generic;
using System.Linq;
using WebApiTest.Models;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly List<CustomerModel> _customerModels = new List<CustomerModel>
            {
                new CustomerModel("customer 1", "123 test street."),
                new CustomerModel("customer 2", "456 test street.")
            };

        public List<CustomerModel> GetCustomers()
        {
            return _customerModels;
        }

        public List<CustomerModel> GetCustomersByName(string name)
        {
            return _customerModels
                .Where(model => model.Name.Contains(name))
                .ToList();
        }

        public List<CustomerModel> GetCustomersByAddress(string address)
        {
            return _customerModels
                .Where(model => model.Address.Contains(address))
                .ToList();
        }

        public List<CustomerModel> GetCustomersByNameAndAddress(string name, string address)
        {
            return _customerModels
                .Where(model => model.Name.Contains(name) && model.Address.Contains(address))
                .ToList();
        }
    }
}