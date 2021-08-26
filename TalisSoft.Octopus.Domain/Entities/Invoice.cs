using System;
using System.Data.Common;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
  public class Invoice: Auditable
  {
    public Guid Id { get; set; }
    public String InvoiceNumber { get; set; }
    public Decimal Amount { get; set; }
    public DateTime? PaidAt { get; set; }
    public string? PaymentMode { get; set; }
    public string Status { get; set; }
  }
}