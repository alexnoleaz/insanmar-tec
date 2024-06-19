using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Auth.Roles;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Roles.Features
{
    public class RolesGetter : ITransientDependency
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IObjectMapper _objectMapper;

        public RolesGetter(IRoleRepository roleRepository, IObjectMapper objectMapper)
        {
            _roleRepository = roleRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<IEnumerable<RoleDto>>> Execute()
        {
            try
            {
                var rolesDb = await _roleRepository.GetAllAsync();
                var rolesDto = _objectMapper.Map<List<RoleDto>>(rolesDb);

                return Result<IEnumerable<RoleDto>>.Success(rolesDto);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<RoleDto>>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
