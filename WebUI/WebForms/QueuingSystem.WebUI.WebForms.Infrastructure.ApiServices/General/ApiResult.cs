using Core.Abstraction.ApiServices.General;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace QueuingSystem.WebUI.WebForms.Infrastructure.ApiServices
{
    public class ApiResult<T> : ApiResult, IApiResult<T>
    {
        public T Value { get; set; }

        public ApiResult(HttpResponseMessage response) : base(response)
        {

        }

        public override async Task ProccessResult()
        {
            Status = (int)response.StatusCode;
            IsSuccess = response.IsSuccessStatusCode;

            if (IsSuccess)
            {
                var content = await response.Content.ReadAsStringAsync();
                Value = typeof(T) == typeof(string) ? (T)Convert.ChangeType(content, typeof(T)) : Deserialize<T>(content);
                return;
            }

            if (Status == (int)HttpStatusCode.BadRequest)
            {
                var content = await response.Content.ReadAsStringAsync();


                ErrorMessage = content;


                return;
            }
        }
    }

    public class ApiResult : IApiResult
    {
        public int Status { get; protected set; }

        public bool IsSuccess { get; protected set; }

        public string ErrorMessage { get; protected set; }

        protected readonly HttpResponseMessage response;

        public ApiResult(HttpResponseMessage response)
        {
            this.response = response;
        }

        public virtual async Task ProccessResult()
        {
            Status = (int)response.StatusCode;
            IsSuccess = response.IsSuccessStatusCode;

            if (IsSuccess)
                return;

            if (Status == (int)HttpStatusCode.BadRequest)
            {
                var content = await response.Content.ReadAsStringAsync();

                ErrorMessage = content;


                return;
            }
        }
       
        public static TContent Deserialize<TContent>(string content)
        {
            try
            {
                var response = JsonConvert.DeserializeObject<ApiResult<TContent>>(content);
                return response.Value; 

            }
            catch (JsonException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
