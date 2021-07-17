using System.Collections.Generic;
using MediatR;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand: IRequest<CreateCustomerVm>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public IEnumerable<Address>? Addresses { get; set; }
    }
}