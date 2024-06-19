using InsanmarTec.Domain.Auth.Roles;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Auth.Users
{
    public class User : AuditedEntity, IPassivable
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsActive { get; set; }
        public HashSet<Role> Roles { get; set; }

        public User()
        {
            IsActive = true;
            Roles = new HashSet<Role>();
        }
    }
}
