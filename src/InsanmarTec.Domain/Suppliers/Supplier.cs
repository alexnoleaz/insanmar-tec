using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Suppliers
{
    public class Supplier : AuditedEntity, IPassivable
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; }

        public Supplier() => IsActive = true;
    }
}
