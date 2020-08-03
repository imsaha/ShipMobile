using System;

namespace ShipMobile.Data.Models
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }

        public long? CreatedById { get; set; }
        public ApplicationUser CreatedBy { get; set; }

        public long? UpdatedById { get; set; }
        public ApplicationUser UpdatedBy { get; set; }
    }
}
