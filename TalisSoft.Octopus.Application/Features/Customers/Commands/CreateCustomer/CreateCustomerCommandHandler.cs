using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TalisSoft.Octopus.Application.Contracts.Persistence;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler: IRequestHandler<CreateCustomerCommand, CreateCustomerVm>
    {
        private readonly ICustomerRepository _customer;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerRepository _customer, IMapper _mapper)
        {
            this._customer = _customer;
            this._mapper = _mapper;
        }
        public async Task<CreateCustomerVm> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request);
            customer = await _customer.AddAsync(customer, cancellationToken).ConfigureAwait(false);
            return _mapper.Map<CreateCustomerVm>(customer);
        }
    }
}