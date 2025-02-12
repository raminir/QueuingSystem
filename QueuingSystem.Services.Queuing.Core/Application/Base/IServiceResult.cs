using System.Net;

namespace QueuingSystem.Services.Queuing.Core.Application.Base
{
    public interface IServiceResult<T>
    {
        public T Value { get; }

        public string ErrorCode { get; }

        public HttpStatusCode Status { get; }
    }
}
