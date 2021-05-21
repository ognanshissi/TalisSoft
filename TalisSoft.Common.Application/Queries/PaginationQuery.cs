using TalisSoft.Common.Application.Enums;

namespace TalisSoft.Common.Application.Queries
{
    public class PaginationQuery
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PaginationQuery()
        {
            PageNumber = (int) PagingQueryEnum.DefaultPageNumber;
            PageSize = (int) PagingQueryEnum.DefaultPageSize;
        }

        public PaginationQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize > (int) PagingQueryEnum.MaxPageSize ? (int) PagingQueryEnum.MaxPageSize: pageSize;
        }
    }
}