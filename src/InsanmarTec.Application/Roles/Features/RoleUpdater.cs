using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Roles;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Roles.Features
{
    public class RoleUpdater : ITransientDependency
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IObjectMapper _objectMapper;

        public RoleUpdater(IRoleRepository roleRepository, IObjectMapper objectMapper)
        {
            _roleRepository = roleRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<RoleDto>> ExecuteAsync(UpdateRoleDto input)
        {
            var result = RoleValidator.Validate(input);
            if (!result.IsValid)
                return Result<RoleDto>.Failure(string.Join(",", result.Errors));

            try
            {
                var roleDb = await _roleRepository.GetAsync(input.Id);
                var roleDto = _objectMapper.Map<RoleDto>(
                    await _roleRepository.UpdateAsync(_objectMapper.Map(input, roleDb))
                );

                return Result<RoleDto>.Success(roleDto);
            }
            catch (EntityNotFoundException ex)
            {
                return Result<RoleDto>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result<RoleDto>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
