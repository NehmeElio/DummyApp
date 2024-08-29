using Microsoft.AspNetCore.Mvc;

namespace DummyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController:ControllerBase
{
    [HttpGet("GetUser")]
    public IActionResult GetUser()
    {
        return Ok("elio-change");
    }
}