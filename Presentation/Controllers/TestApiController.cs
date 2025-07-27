using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        [HttpGet("test-exception")]
        public IActionResult TestException()
        {
            throw new Exception("This is a test");
        }
    }
}
