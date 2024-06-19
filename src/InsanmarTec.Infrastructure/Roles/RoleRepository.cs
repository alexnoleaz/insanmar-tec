using InsanmarTec.Domain.Auth.Roles;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Infrastructure.Shared.Repositories;

namespace InsanmarTec.Infrastructure.Roles
{
    public class RoleRepository : AsyncCrudRepository<Role>, IRoleRepository
    {
        public RoleRepository(IDatasource<Role> roleDatasource)
            : base(roleDatasource) { }
    }
}
