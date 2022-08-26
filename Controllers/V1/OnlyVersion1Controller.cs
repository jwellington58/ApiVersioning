using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class OnlyVersion1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVersion()
            => Ok("this api only exists in version 1.0");
    }
}
