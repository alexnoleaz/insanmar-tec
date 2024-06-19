using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Auth.Users;

namespace InsanmarTec.Application.Users
{
    public class UserValidator
    {
        public static ValidationResult Validate(CreateUserDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.FirstName) || string.IsNullOrWhiteSpace(input.FirstName))
                result.Errors.Add("Se require el nombre.");

            if (input.FirstName?.Length > UserConsts.MaxFirstNameLength)
                result.Errors.Add(
                    $"El nombre no puede tener más de {UserConsts.MaxFirstNameLength} caracteres."
                );

            if (string.IsNullOrEmpty(input.LastName) || string.IsNullOrWhiteSpace(input.LastName))
                result.Errors.Add("Se require el apellido.");

            if (input.LastName?.Length > UserConsts.MaxLastNameLength)
                result.Errors.Add(
                    $"El apellido no puede tener más de {UserConsts.MaxLastNameLength} caracteres."
                );

            if (string.IsNullOrEmpty(input.Password) || string.IsNullOrWhiteSpace(input.Password))
                result.Errors.Add("Se require la contraseña.");

            if (input.Password?.Length > UserConsts.MaxPasswordLength)
                result.Errors.Add(
                    $"La contraseña no puede tener más de {UserConsts.MaxPasswordLength} caracteres."
                );

            ValidateCommonFields(input.Username, input.Email, result);
            return result;
        }

        public static ValidationResult Validate(UpdateUserDto input)
        {
            var result = new ValidationResult();
            ValidateCommonFields(input.Username, input.Email, result);
            return result;
        }

        private static void ValidateCommonFields(
            string username,
            string email,
            ValidationResult result
        )
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
                result.Errors.Add("Se require el nombre de usuario");

            if (username?.Length > UserConsts.MaxUsernameLength)
                result.Errors.Add(
                    $"El nombre de usuario no puede tener más de {UserConsts.MaxUsernameLength} caracteres."
                );

            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
                result.Errors.Add("Se require el correo electrónico.");

            if (email?.Length > UserConsts.MaxEmailLength)
                result.Errors.Add(
                    $"El correo electrónico no puede tener más de {UserConsts.MaxUsernameLength} caracteres."
                );
        }
    }
}
