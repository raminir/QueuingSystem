using QueuingSystem.Services.Queuing.Core.Application.Base;
using System.Net;

namespace QueuingSystem.Services.Queuing.Infrastructure.Application.Base
{
    public class ServiceResult<T> : IServiceResult<T>
    {
        public T Value { get; init; }

        public string ErrorCode { get; init; }

        public HttpStatusCode Status { get; init; }

        public static ServiceResult<T> Ok(T value)
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.OK,
                Value = value
            };
        }

        public static ServiceResult<T> NotFound()
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.NotFound
            };
        }

        public static ServiceResult<T> BadRequest()
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.BadRequest,
                ErrorCode = "400510"
            };
        }

        public static ServiceResult<T> Created(T value)
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.Created,
                Value = value
            };
        }
    }
}
