using System;

namespace TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList
{
    public class CustomerListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }
}