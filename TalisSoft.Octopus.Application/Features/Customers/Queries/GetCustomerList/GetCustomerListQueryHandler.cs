using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TalisSoft.Octopus.Application.Contracts.Persistence;

namespace TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQueryHandler: IRequestHandler<GetCustomerListQuery, List<CustomerListVm>>
    {
        private readonly ICustomerRepository _customer;
        private readonly IMapper _mapper;

        public GetCustomerListQueryHandler(ICustomerRepository customer, IMapper mapper)
        {
            _customer = customer;
            _mapper = mapper;
        }
        public async Task<List<CustomerListVm>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customer.GetAllAsync(cancellationToken).ConfigureAwait(false);
            return _mapper.Map<List<CustomerListVm>>(customers);
        }
    }
}