using System;
using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
  public class Campaign: Auditable
  {
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public Path Path { get; set; }
    public Guid PathId { get; set; }
    public IEnumerable<Shipment> Shipments { get; set; } = new List<Shipment>();
  }
}