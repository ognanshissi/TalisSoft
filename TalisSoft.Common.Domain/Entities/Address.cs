
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace TalisSoft.Common.Domain.Entities
{
  public class Address
  {
    public string Title { get; set; } // Payment Address, Delivery Address,  Home, Work, Favorite Restaurant ...
    public string City { get; set; }
    public string? PostalCode { get; set; }
    public string Country { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public bool IsDefault { get; set; }
    
    public Coordinate Coordinates { get; set; }
    
    public Address()
    {
      IsDefault = false;
    }
  }
}