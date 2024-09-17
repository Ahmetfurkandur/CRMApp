using Application.Features.Customer.Commands.AddCustomerCommands;
using Application.Features.Customer.Commands.DeleteCustomerCommands;
using Application.Features.Customer.Commands.UpdateCustomerCommands;
using Application.Features.Customer.Queries.GetAllCustomersQueries;
using Application.Features.Customer.Queries.GetCustomerDetailQueries;
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
        public async Task<IActionResult> GetDetail([FromQuery]GetCustomerDetailQueryRequest request)
        {
            var customer = await Mediator.Send(request);
            return Ok(customer);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCustomersQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery]DeleteCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }
    }
}
