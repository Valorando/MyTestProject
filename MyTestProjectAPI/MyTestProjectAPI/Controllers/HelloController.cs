using MyTestProjectAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyTestProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IHelloRepository _newService;

        public HelloController(IHelloRepository newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            var message = _newService.Hello();
            return Ok(message);
        }
    }
}
