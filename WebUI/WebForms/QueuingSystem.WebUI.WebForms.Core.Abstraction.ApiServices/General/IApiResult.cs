namespace Core.Abstraction.ApiServices.General
{
    public interface IApiResult<T> : IApiResult
    {
        T Value { get; }
    }

    public interface IApiResult
    {
        int Status { get; }

        bool IsSuccess { get; }

        string ErrorMessage { get; }
    }
}
