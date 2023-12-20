using Microsoft.AspNetCore.Mvc;

namespace ToDoApiV2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUserController : ControllerBase
    {

        private readonly ILogger<AppUserController> _logger;

        public AppUserController(ILogger<AppUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAppUser")]
        public IActionResult Get()
        {
            return Ok("Server Up and running");
        }
    }
}
