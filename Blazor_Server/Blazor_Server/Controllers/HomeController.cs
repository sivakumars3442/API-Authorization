using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_Server.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("GetData")]
        [Authorize]
        public IActionResult GetData()
        {
            string authorizationHeader = HttpContext.Request.Headers["Authorization"];
            // Your logic to fetch data
            return Ok();
        }
    }
}
