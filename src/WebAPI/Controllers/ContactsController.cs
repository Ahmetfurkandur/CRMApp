using Application.Features.Contact.Commands.AddContactCommands;
using Application.Features.Contact.Commands.DeleteContactCommands;
using Application.Features.Contact.Commands.UpdateContactCommands;
using Application.Features.Contact.Queries.GetAllContactsQueries;
using Application.Features.Contact.Queries.GetContactsByNameQueries;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactsController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetByName([FromQuery]GetContactsByNameQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response.Data);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllContactsQueryRequest request)
        {
            GetAllContactsQueryResponse response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddContactCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateContactCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery]DeleteContactCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }
    }
}
