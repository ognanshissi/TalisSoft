using System;
using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
  /// <summary>
  /// Shipment
  ///
  /// 
  /// </summary>
  public class Shipment: Auditable
  {
    public string ShipmentNo { get; set; }
    public Customer Customer { get; set; } // can be the connected user that want to send a package somewhere
    public bool IsLinkedCampaign { get; set; }
    public Campaign? Campaign { get; set; }
    public Guid? CampaignId { get; set; } // some shipment are not associated to a campaign
    public Path Path { get; set; }
    public Guid PathId { get; set; }
    public IEnumerable<Pack> Packages { get; set; }
    public Decimal Amount { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? PaymentMode { get; set; }
    public string Status { get; set; } // Created, Waiting, Process, Shipped, Delivered


    public Shipment()
    {
      Status = "Created";
    }
  }
}