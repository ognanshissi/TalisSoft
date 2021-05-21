using System;

namespace TalisSoft.Octopus.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}