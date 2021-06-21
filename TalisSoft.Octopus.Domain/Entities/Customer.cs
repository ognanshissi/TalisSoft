using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
    public class Customer: Person
    {
      public string Email { get; set; }
      
        public IEnumerable<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}