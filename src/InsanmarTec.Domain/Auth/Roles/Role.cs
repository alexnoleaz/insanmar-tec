using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Auth.Roles
{
    public class Role : AuditedEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public HashSet<User> Users { get; set; }

        public Role() => Users = new HashSet<User>();
    }
}
