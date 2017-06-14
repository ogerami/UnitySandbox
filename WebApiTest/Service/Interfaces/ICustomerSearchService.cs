using System.Collections.Generic;
using WebApiTest.Models;

namespace WebApiTest.Service.Interfaces
{
    public interface ICustomerSearchService
    {
        List<CustomerModel> Search(CustomerSearchModel searchModel);
    }
}