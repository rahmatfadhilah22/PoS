using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValueController : BaseController
{
    [HttpGet("GetValue")]
    public IActionResult Get()
    {
        return Ok();
    }

}