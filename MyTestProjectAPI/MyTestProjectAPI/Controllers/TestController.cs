using MyTestProjectAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyTestProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _newService;

        public TestController(ITestService newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            var message = _newService.GetMessage();
            return Ok(message);
        }
    }
}
