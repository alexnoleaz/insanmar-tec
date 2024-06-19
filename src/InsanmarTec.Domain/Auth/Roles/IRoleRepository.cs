using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Auth.Roles
{
    public interface IRoleRepository : IAsyncCrudRepository<Role> { }
}
