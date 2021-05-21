using MediatR;

namespace TalisSoft.Octopus.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand: IRequest<CreateCustomerVm>
    {
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}