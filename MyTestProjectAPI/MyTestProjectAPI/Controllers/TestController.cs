using Microsoft.AspNetCore.Mvc;

namespace MyTestProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet("hello")]
        public IActionResult GetHelloWorld()
        {
            return Ok("Hello World");
        }
    }
}
