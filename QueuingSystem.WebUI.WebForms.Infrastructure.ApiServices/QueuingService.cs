using Core.Abstraction.ApiServices;
using Core.Abstraction.ApiServices.General;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApiServices
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
    }
}
