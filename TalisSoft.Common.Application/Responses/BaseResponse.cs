using System.Collections.Generic;

namespace TalisSoft.Common.Application.Responses
{
    public class BaseResponse<T> where T: class
    {
        public BaseResponse()
        {
            Success = true;
        }
        public BaseResponse(string message = null)
        {
            Success = true;
            Message = message;
        }

        public BaseResponse(string message, bool success)
        {
            Success = success;
            Message = message;
            Data = null;
        }

        public BaseResponse(T response)
        {
            Success = true;
            Message = null;
            Data = response;
        }
        
        public BaseResponse(T data, string message = null, bool success = true)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        
        public T Data { get; set; }
    }
}