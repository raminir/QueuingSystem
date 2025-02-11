using Core.Abstraction.ApiServices;
using Core.Abstraction.ApiServices.General;
using System.Net.Http;
using System.Threading.Tasks;

namespace QueuingSystem.WebUI.WebForms.Infrastructure.ApiServices
{
    public class ApiClient : IApiClient
    {
        public async Task<IApiResult<T>> GetAsync<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = new ApiResult<T>(await client.GetAsync(url));
                await response.ProccessResult();
                return response;
            }
        }
    }
}
