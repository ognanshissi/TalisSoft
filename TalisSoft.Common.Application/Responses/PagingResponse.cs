using System.Collections.Generic;

namespace TalisSoft.Common.Application.Responses
{
    public class PagingResponse<T> where T: class
    {
        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
        public int? TotalCount { get; set; }

        public IEnumerable<T> Data { get; set; }
        
        public PagingResponse() {}

        public PagingResponse(IEnumerable<T> data)
        {
            Data = data;
        }

    }
}