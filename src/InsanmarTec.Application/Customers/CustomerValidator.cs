using InsanmarTec.Application.Customers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Customers;

namespace InsanmarTec.Application.Customers
{
    public class CustomerValidator
    {
        public static ValidationResult Validate(CreateCustomerDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.FirstName) || string.IsNullOrWhiteSpace(input.FirstName))
                result.Errors.Add("Se requiere el nombre completo.");

            if (input.FirstName?.Length > CustomerConsts.MaxFirstNameLength)
                result.Errors.Add(
                    $"El nombre completo no puede tener más de {CustomerConsts.MaxFirstNameLength} caracteres."
                );

            if (string.IsNullOrEmpty(input.LastName) || string.IsNullOrWhiteSpace(input.LastName))
                result.Errors.Add("Se requieren los apellidos.");

            if (input.LastName?.Length > CustomerConsts.MaxLastNameLength)
                result.Errors.Add(
                    $"Los apellidos no pueden tener más de {CustomerConsts.MaxLastNameLength} caracteres."
                );

            ValidateCommonFields(input.Address, input.Phone, input.Email, result);

            if (string.IsNullOrEmpty(input.Dni) || string.IsNullOrWhiteSpace(input.Dni))
                result.Errors.Add("Se requiere el dni.");

            if (input.Dni?.Length > CustomerConsts.MaxDniLength)
                result.Errors.Add(
                    $"El DNI no puede tener más de {CustomerConsts.MaxDniLength} caracteres."
                );

            return result;
        }

        public static ValidationResult Validate(UpdateCustomerDto input)
        {
            var result = new ValidationResult();
            ValidateCommonFields(input.Address, input.Phone, input.Email, result);
            return result;
        }

        private static void ValidateCommonFields(
            string address,
            string phone,
            string email,
            ValidationResult result
        )
        {
            if (string.IsNullOrEmpty(address) || string.IsNullOrWhiteSpace(address))
                result.Errors.Add("Se requiere la dirección.");

            if (address?.Length > CustomerConsts.MaxAddressLength)
                result.Errors.Add(
                    $"La dirección no puede tener más de {CustomerConsts.MaxAddressLength} caracteres."
                );

            if (string.IsNullOrEmpty(phone) || string.IsNullOrWhiteSpace(phone))
                result.Errors.Add("Se requiere el teléfono.");

            if (address?.Length > CustomerConsts.MaxPhoneLength)
                result.Errors.Add(
                    $"El teléfono no puede tener más de {CustomerConsts.MaxPhoneLength} caracteres."
                );

            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
                result.Errors.Add("Se requiere el correo electrónico.");

            if (address?.Length > CustomerConsts.MaxEmailLength)
                result.Errors.Add(
                    $"El correo electrónico no puede tener más de {CustomerConsts.MaxEmailLength} caracteres."
                );
        }
    }
}
