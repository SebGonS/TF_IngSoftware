using Ecommerce.Dto;
using Ecommerce.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<CustomerDto> List([FromQuery] string filter)
        {
            return _service.GetCollection(filter);
        }

        [HttpGet]
        [Route("{id:int}")]
        public CustomerDto Get(int id)
        {
            return _service.GetCustomer(id);
        }

        [HttpPost]
        public void Post([FromBodyAttribute]CustomerDto request)
        {
            _service.Create(request);
        }
    }
}
