using System;
using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerVm
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}