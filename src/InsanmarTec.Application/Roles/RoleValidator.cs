using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Roles;

namespace InsanmarTec.Application.Roles
{
    public class RoleValidator
    {
        public static ValidationResult Validate(CreateRoleDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.Name) || string.IsNullOrWhiteSpace(input.Name))
                result.Errors.Add("Se requiere el nombre.");

            if (input.Name?.Length > RoleConsts.MaxNameLength)
                result.Errors.Add(
                    $"El nombre no puede tener más de {RoleConsts.MaxNameLength} caracteres."
                );

            ValidateCommonField(input.Description, result);
            return result;
        }

        public static ValidationResult Validate(UpdateRoleDto input)
        {
            var result = new ValidationResult();
            ValidateCommonField(input.Description, result);
            return result;
        }

        public static void ValidateCommonField(string description, ValidationResult result)
        {
            if (string.IsNullOrEmpty(description) || string.IsNullOrWhiteSpace(description))
                result.Errors.Add("Se requiere la descripción.");

            if (description?.Length > RoleConsts.MaxDescriptionLength)
                result.Errors.Add(
                    $"La descripción no puede tener más de {RoleConsts.MaxDescriptionLength} caracteres."
                );
        }
    }
}
