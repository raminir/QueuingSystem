using Core.Abstraction.ApiServices.General;
using QueuingSystem.WebUI.WebForms.Core.Dto;
using System.Threading.Tasks;

namespace Core.Abstraction.ApiServices
{
    public interface IQueuingService
    {
        Task<IApiResult<string>> Get();
        Task<IApiResult<System.Collections.Generic.List<TicketInRoomDto>>> GetTicketsInProgressForTodayService();
    }
}
