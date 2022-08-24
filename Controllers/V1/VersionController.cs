using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1;

[ApiController]
[Route("[controller]")]
[ApiVersion("1.0")]
public class VersionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetVersion()
        => Ok("You are in version 1.0");
}
