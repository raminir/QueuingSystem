using Core.Abstraction.ApiServices;
using Core.Abstraction.ApiServices.General;
using Infrastructure.Implementation.ApiServices.General;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApiServices
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient client;
        private IHttpContextAccessor _httpContextAccessor;

        public ApiClient(IHttpClientFactory clientFactory, IHttpContextAccessor httpContextAccessor)
        {
            client = clientFactory.CreateClient("Gateway");
            _httpContextAccessor = httpContextAccessor;

        }

        public async Task<IApiResult<T>> GetAsync<T>(string url, string version = null)
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (!string.IsNullOrEmpty(version))
            {
                client.DefaultRequestHeaders.Add("X-Api-Version", version);
            }
            var response = new ApiResult<T>(await client.GetAsync(url));
            await response.ProccessResult();
            return response;
        }
    }
}
