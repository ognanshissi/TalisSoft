using System;
using System.Collections.Generic;

namespace TalisSoft.Common.Domain.Entities
{
  public class Person: Auditable
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? FullName { get; set; } // automatically filled
    public string PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string DefaultTimeZone { get; set; }
    public string Language { get; set; }
    public List<Address> Addresses { get; set; }


    public Person()
    {
      Language = "fr"; // en
      DefaultTimeZone = "GMT";
      Addresses = new List<Address>();
    }
  }
}