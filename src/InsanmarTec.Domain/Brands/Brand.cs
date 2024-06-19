using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Brands
{
    public class Brand : AuditedEntity, IPassivable
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public bool IsActive { get; set; }

        public Brand() => IsActive = true;
    }
}
