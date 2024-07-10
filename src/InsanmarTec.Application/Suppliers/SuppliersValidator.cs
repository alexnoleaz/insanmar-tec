using InsanmarTec.Application.Suppliers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Suppliers;

namespace InsanmarTec.Application.Brands
{
    public class SupplierValidator
    {
        public static ValidationResult Validate(CreateSuppliersDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.Name) || string.IsNullOrWhiteSpace(input.Name))
                result.Errors.Add("Se requiere el nombre.");

            if (input.Name?.Length > SupplierConsts.MaxNameLength)
                result.Errors.Add(
                    $"El nombre no puede tener más de {SupplierConsts.MaxNameLength} caracteres."
                );

            ValidateCommonFields(input.mail, input.phone, input.address, result);
            return result;
        }

        public static ValidationResult Validate(UpdateSuppliersDto input)
        {
            var result = new ValidationResult();
            ValidateCommonFields(input.mail, input.phone, input.address, result);
            return result;
        }

        private static void ValidateCommonFields(
            string mail,
            string phone,
            string address,
            ValidationResult result
        )
        {
            if (string.IsNullOrEmpty(mail) || string.IsNullOrWhiteSpace(mail))
                result.Errors.Add("Se requiere la descripción.");

            if (mail?.Length > SupplierConsts.MaxEmailLength)
                result.Errors.Add(
                    $"La descripción no puede tener más de {SupplierConsts.MaxEmailLength} caracteres."
                );

            if (string.IsNullOrEmpty(phone) || string.IsNullOrWhiteSpace(phone))
                result.Errors.Add("Se requiere la categoría.");

            if (phone?.Length > SupplierConsts.MaxPhoneLength)
                result.Errors.Add(
                    $"La categoría no puede tener más de {SupplierConsts.MaxPhoneLength} caracteres."
                );
        }
    }
}
