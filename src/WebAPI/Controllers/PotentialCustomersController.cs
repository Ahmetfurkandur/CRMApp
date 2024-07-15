using Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands;
using Application.Features.PotentialCustomer.Queries.GetAllPotentialCustomersQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PotentialCustomersController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllPotentialCustomersQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPotentialCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }


    }
}
