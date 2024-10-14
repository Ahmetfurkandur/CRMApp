using Application.Features.Deals.Queries.GetAllDealsQuery;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DealsController : BaseController
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = Mediator.Send(new GetAllDealsQueryRequest());
            return Ok(response);
        }
    }
}
