using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V2
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("2.0")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVersion()
            => Ok("You are in version 2.0");
    }
}
