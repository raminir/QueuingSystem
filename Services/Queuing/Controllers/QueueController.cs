using Microsoft.AspNetCore.Mvc;
using QueuingSystem.Services.Queuing.Core.Application.Base;
using QueuingSystem.Services.Queuing.Core.Application.Outputs;
using QueuingSystem.Services.Queuing.Core.Application.Services;

[Route("api/queuing")]
[ApiController]
public class QueueController : ControllerBase
{
    private readonly IGetTicketsInProgressForTodayService _ticketsInProgressForTodayService;

    public QueueController(IGetTicketsInProgressForTodayService ticketsInProgressForTodayService)
    {
        _ticketsInProgressForTodayService = ticketsInProgressForTodayService;
    }

    [HttpGet("inprogress-for-today-service")]
    public async Task<IServiceResult<List<TicketInRoomOutput>>> GetTicketsInProgressForTodayService()
    {
        return await _ticketsInProgressForTodayService.GetAsync();
    }

    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("Queuing Service is working!");
    }
}