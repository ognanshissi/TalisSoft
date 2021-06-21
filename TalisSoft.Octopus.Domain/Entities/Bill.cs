using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
  public class Bill: Auditable
  {
    public string BillNo { get; set; }
  }
}