using System;
using System.Collections.Generic;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
  public class Pack: Auditable
  {
    public string PackNo { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public Decimal EstimatedValue { get; set; }
    public Decimal Cost { get; set; }
    public Dimension Dimension { get; set; } // JSON
    public List<string> Images { get; set; } = new List<string>();
    public string Status { get; set; } // Created, 
  }


  public class Dimension
  {
    public Decimal Height { get; set; }
    public Decimal Weight { get; set; }
    public Decimal Length { get; set; }
    public Decimal Width { get; set; }
  }
}