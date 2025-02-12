using QueuingSystem.Services.Queuing.Core.Application.Base;
using QueuingSystem.Services.Queuing.Core.Application.Outputs;

namespace QueuingSystem.Services.Queuing.Core.Application.Services
{
    public interface IGetTicketsInProgressForTodayService
    {
        Task<IServiceResult<List<TicketInRoomOutput>>> GetAsync();
    }
}
