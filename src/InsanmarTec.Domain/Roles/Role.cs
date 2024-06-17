using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Roles
{
    public class Role : FullAuditedEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
