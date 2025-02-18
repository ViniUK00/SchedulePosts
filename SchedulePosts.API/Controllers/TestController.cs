using Microsoft.AspNetCore.Mvc;

namespace SchedulePosts.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        // GET: api/test
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test endpoint is working!");
        }

    }
}