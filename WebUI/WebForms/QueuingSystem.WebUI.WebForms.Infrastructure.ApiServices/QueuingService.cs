using Core.Abstraction.ApiServices;
using Core.Abstraction.ApiServices.General;
using QueuingSystem.WebUI.WebForms.Core.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QueuingSystem.WebUI.WebForms.Infrastructure.ApiServices
{
    public class QueuingService : IQueuingService
    {
        private readonly IApiClient apiClient;
        private readonly ApiConfig apiConfig;

        public QueuingService(
            IApiClient apiClient,
            ApiConfig apiConfig)
        {
            this.apiClient = apiClient;
            this.apiConfig = apiConfig;
        }

        public async Task<IApiResult<string>> Get()
        {
            return await apiClient.GetAsync<string>(apiConfig.GetQueuing());
        }
        public async Task<IApiResult<List<TicketInRoomDto>>> GetTicketsInProgressForTodayService()
        {
            return await apiClient.GetAsync<List<TicketInRoomDto>>(apiConfig.GetTicketsInProgressForTodayService());
        }
    }
}
