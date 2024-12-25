using Microsoft.AspNetCore.Mvc;

namespace RealtimeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTest")]
        public string Get()
        {
            return "Test method ran successfully.";
        }
    }
}
