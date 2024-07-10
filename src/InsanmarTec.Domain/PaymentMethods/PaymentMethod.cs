using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.PaymentMethods
{
    public class PaymentMethod : CreationAuditedEntity, IPassivable
    {
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public PaymentMethod() => IsActive = true;
    }
}
