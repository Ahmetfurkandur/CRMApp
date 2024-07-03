using Application.Features.Contact.Commands.AddContactCommands;
using Application.Features.Contact.Commands.DeleteContactCommands;
using Application.Features.Contact.Commands.UpdateContactCommands;
using Application.Features.Contact.Queries.GetAllContactsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : BaseController
    {
        [HttpGet]
        [Route("/getall")]
        public async Task<IActionResult> GetAllContacts([FromQuery]GetAllContactsQueryRequest request)
        {
            GetAllContactsQueryResponse response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("/add")]
        public async Task<IActionResult> AddContact(AddContactCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpPut]
        [Route("/update")]
        public async Task<IActionResult> UpdateContact(UpdateContactCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        [Route("/delete")]
        public async Task<IActionResult> DeleteContact([FromQuery]DeleteContactCommandRequest request)
        {
            await Mediator.Send(request);
            return NoContent();
        }
    }
}
