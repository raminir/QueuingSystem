using QueuingSystem.Services.Queuing.Core.Application.Enums;

namespace QueuingSystem.Services.Queuing.Core.Application.Outputs
{
    public class TicketInRoomOutput
    {
        public int Id { get; set; }
        public string? RoomName { get; set; }
        public string? DepartmentName { get; set; }
        public int TicketNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public StatusEnum StatusId { get; set; }
    }
}
