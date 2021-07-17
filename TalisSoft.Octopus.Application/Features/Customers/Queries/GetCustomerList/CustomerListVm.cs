using System;
using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList
{
    public class CustomerListVm
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        
        public int CustomerNo { get; set; }

        public int AddressesCount { get; set; }

        public string FullName { get; set; }
        
        public CustomerListVm()
        {
          AddressesCount = 0;
        }
    }
}