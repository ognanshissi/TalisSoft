using System;

namespace TalisSoft.Common.Domain.Entities
{
  public class Coordinates
  {
    public Double Lng { get; set; }
    public Double Lat { get; set; }


    public Coordinates()
    {
      Lat = 0.00;
      Lng = 0.00;
    }
  }
}