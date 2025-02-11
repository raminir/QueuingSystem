using Core.Abstraction.ApiServices.General;
using System.Threading.Tasks;

namespace Core.Abstraction.ApiServices
{
    public interface IApiClient
    {
        Task<IApiResult<T>> GetAsync<T>(string url, string version = null);
    }
}
