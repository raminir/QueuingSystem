
using ByCheck.Services.Blog.Infrastructure.Application.Base;
using QueuingSystem.Services.Queuing.Core.Application.Base;
using QueuingSystem.Services.Queuing.Core.Application.Outputs;
using QueuingSystem.Services.Queuing.Core.Application.Services;

namespace QueuingSystem.Services.Queuing.Infrastructure.Application.Services
{
    public class GetTicketsInProgressForTodayService : IGetTicketsInProgressForTodayService
    {
        public async Task<IServiceResult<List<TicketInRoomOutput>>> GetAsync()
        {
            var model = new List<TicketInRoomOutput>();
            model.Add(new TicketInRoomOutput()
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                DepartmentName = "Department name",
                RoomName = "Room name",
                StatusId = Core.Application.Enums.StatusEnum.InProgress,
                TicketNumber = 100
            });
            return ServiceResult<List<TicketInRoomOutput>>.Ok(model);
        }
    }
}