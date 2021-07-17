using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
    public class Customer: Person
    {
      public int CustomerNo { get; set; }
      public string Email { get; set; }
      
      public IEnumerable<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}