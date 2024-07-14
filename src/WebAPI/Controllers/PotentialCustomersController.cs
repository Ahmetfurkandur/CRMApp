using Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PotentialCustomersController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Add(AddPotentialCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }
    }
}
