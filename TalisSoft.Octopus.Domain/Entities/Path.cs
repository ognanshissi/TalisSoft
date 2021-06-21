using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
  /// <summary>
  /// Path predefined routes for upcoming shipment
  /// Normally user can use these path for campaign
  ///
  /// Later on this Entity can be used to trace a path on map
  /// </summary>
  public class Path: Auditable
  {
    public Address Source { get; set; }
    public Address Destination { get; set; }
  }
}