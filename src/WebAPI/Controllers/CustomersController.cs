using Application.Features.Customer.Commands.AddCustomerCommands;
using Application.Features.Customer.Queries.GetAllCustomersQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Add(AddCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllCustomersQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }
    }
}
