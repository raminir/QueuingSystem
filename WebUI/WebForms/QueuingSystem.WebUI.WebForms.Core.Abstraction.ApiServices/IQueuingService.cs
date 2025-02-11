using Core.Abstraction.ApiServices.General;
using System.Threading.Tasks;

namespace Core.Abstraction.ApiServices
{
    public interface IQueuingService
    {
        Task<IApiResult<string>> Get();
    }
}
