using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Auth.Roles;
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

        public async Task<Result> Execute(CreateRoleDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.Name) || string.IsNullOrWhiteSpace(input.Name))
                result.Errors.Add("Se requiere el nombre.");

            if (input.Name?.Length > RoleConsts.MaxNameLength)
                result.Errors.Add(
                    $"El nombre no puede tener más de {RoleConsts.MaxNameLength} caracteres."
                );

            if (
                string.IsNullOrEmpty(input.Description)
                || string.IsNullOrWhiteSpace(input.Description)
            )
                result.Errors.Add("Se requiere la descripción.");

            if (input.Description?.Length > RoleConsts.MaxDescriptionLength)
                result.Errors.Add(
                    $"La descripción no puede tener más de {RoleConsts.MaxDescriptionLength} caracteres."
                );

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
