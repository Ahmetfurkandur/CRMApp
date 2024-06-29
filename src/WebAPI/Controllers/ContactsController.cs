using Application.Features.Contact.Commands.AddContactCommands;
using Application.Features.Contact.Queries.GetAllContactsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        IMediator _meditor;

        public ContactsController(IMediator meditor)
        {
            _meditor = meditor;
        }

        [HttpGet]
        [Route("/getall")]
        public async Task<IActionResult> GetAllContacts([FromQuery]GetAllContactsQueryRequest request)
        {
            GetAllContactsQueryResponse response = await _meditor.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("/add")]
        public async Task<IActionResult> AddContact(AddContactCommandRequest request)
        {
            AddContactCommandResponse response = await _meditor.Send(request);
            return Ok(response);
        }
    }
}
