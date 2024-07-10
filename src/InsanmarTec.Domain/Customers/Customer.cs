using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Customers
{
    public class Customer : AuditedEntity, IPassivable
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public bool IsActive { get; set; }

        public Customer() => IsActive = true;
    }
}
