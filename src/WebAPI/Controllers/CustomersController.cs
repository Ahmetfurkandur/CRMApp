using Application.Features.Customer.Commands.AddCustomerCommands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController
    {

        [HttpPost]
        [Route("/add")]
        public async Task<IActionResult> Add(AddCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }
    }
}
