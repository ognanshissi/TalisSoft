using System.Collections.Generic;
using MediatR;

namespace TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQuery: IRequest<List<CustomerListVm>>
    {
        
    }
}