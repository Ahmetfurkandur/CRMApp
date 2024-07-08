using Application.Features.Customer.Commands.AddCustomerCommands;
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
    }
}
