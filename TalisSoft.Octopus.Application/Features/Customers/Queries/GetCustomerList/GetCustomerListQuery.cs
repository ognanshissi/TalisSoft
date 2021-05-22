using System.Collections.Generic;
using MediatR;
using TalisSoft.Common.Application.Responses;

namespace TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQuery: IRequest<List<CustomerListVm>>
    {
        
    }
}