using Application.Features.PotentialCustomer.Commands.AddPotentialCustomerCommands;
using Application.Features.PotentialCustomer.Commands.DeletePotentialCustomerCommands;
using Application.Features.PotentialCustomer.Commands.UpdatePotentialCustomerCommands;
using Application.Features.PotentialCustomer.Queries.GetAllPotentialCustomersQueries;
using Application.Features.PotentialCustomer.Queries.GetPotentialCustomerDetailQueries;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PotentialCustomersController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetDetail([FromQuery] GetPotentialCustomerDetailQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

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

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePotentialCustomerCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeletePotentialCustomerCommandRequest(id));
            return NoContent();
        }
    }
}
