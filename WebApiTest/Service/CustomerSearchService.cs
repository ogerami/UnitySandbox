using System;
using System.Collections.Generic;
using WebApiTest.Models;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Service
{
    public class CustomerSearchService : ICustomerSearchService
    {
        private readonly ICustomerService _customerService;

        private readonly List<Func<CustomerSearchModel, ICustomerService, List<CustomerModel>>> _search
            = new List<Func<CustomerSearchModel, ICustomerService, List<CustomerModel>>>
            {
                (model, service)
                    => !string.IsNullOrWhiteSpace(model.Name) && string.IsNullOrWhiteSpace(model.Address) ?
                        service.GetCustomersByName(model.Name) :
                        null,
                (model, service)
                    => string.IsNullOrWhiteSpace(model.Name) && !string.IsNullOrWhiteSpace(model.Address) ?
                        service.GetCustomersByAddress(model.Name) :
                        null,
                (model, service)
                    => !string.IsNullOrWhiteSpace(model.Name) && !string.IsNullOrWhiteSpace(model.Address) ?
                        service.GetCustomersByNameAndAddress(model.Name, model.Address) :
                        null
            };

        public CustomerSearchService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public List<CustomerModel> Search(CustomerSearchModel searchModel)
        {
            foreach (var func in _search)
            {
                var list = func(searchModel, _customerService);
                if (list != null)
                    return list;
            }
            return _customerService.GetCustomers();
        }
    }
}