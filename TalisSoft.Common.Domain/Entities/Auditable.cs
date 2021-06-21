using System;

namespace TalisSoft.Common.Domain.Entities
{
    public class Auditable
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public Auditable()
        {
          CreatedAt = DateTime.UtcNow;
          IsDeleted = false;
        }
        
    }
}