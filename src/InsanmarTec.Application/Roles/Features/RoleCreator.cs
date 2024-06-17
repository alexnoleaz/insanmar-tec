using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Roles;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Roles.Features
{
    public class RoleCreator : ITransientDependency
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IObjectMapper _objectMapper;

        public RoleCreator(IRoleRepository roleRepository, IObjectMapper objectMapper)
        {
            _roleRepository = roleRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result> ExecuteAsync(CreateRoleDto input)
        {
            var result = RoleValidator.Validate(input);
            if (!result.IsValid)
                return Result.Failure(string.Join(",", result.Errors));

            try
            {
                var role = _objectMapper.Map<Role>(input);
                await _roleRepository.CreateAsync(role);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
