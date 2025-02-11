using Microsoft.AspNetCore.Mvc;

[Route("api/queuing")]
[ApiController]
public class QueueController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("Queuing Service is working!");
    }
}