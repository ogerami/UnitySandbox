using System.Web.Http;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [Route("api/Customers")]
        [Route("api/Customers-Audit")]
        [HttpGet]
        public IHttpActionResult GetAllCustomers()
        {
            var customers = _customerService.GetCustomers();

            return Ok(customers);
        }
    }
}