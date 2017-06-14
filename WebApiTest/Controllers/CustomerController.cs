using System.Web.Http;
using WebApiTest.Models;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerSearchService _customerSearchService;

        public CustomerController(ICustomerSearchService customerSearchService)
        {
            _customerSearchService = customerSearchService;
        }
       
        [Route("api/Customers")]
        //[Route("api/Customers-Audit")]
        [HttpGet]
        public IHttpActionResult GetAllCustomers(string name = null, string address = null)
        {
            var customers = _customerSearchService.Search(new CustomerSearchModel
            {
                Name = name,
                Address = address
            });

            return Ok(customers);
        }
    }
}