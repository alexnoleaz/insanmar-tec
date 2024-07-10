using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;

namespace InsanmarTec.Application.Brands
{
    public class BrandValidator
    {
        public static ValidationResult Validate(CreateSuppliersDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.Name) || string.IsNullOrWhiteSpace(input.Name))
                result.Errors.Add("Se requiere el nombre.");

            if (input.Name?.Length > BrandConsts.MaxNameLength)
                result.Errors.Add(
                    $"El nombre no puede tener más de {BrandConsts.MaxNameLength} caracteres."
                );

            ValidateCommonFields(input.Description, input.Category, result);
            return result;
        }

        public static ValidationResult Validate(UpdateSuppliersDto input)
        {
            var result = new ValidationResult();
            ValidateCommonFields(input.Description, input.Category, result);
            return result;
        }

        internal static object Validate(Suppliers.Dtos.UpdateSuppliersDto input)
        {
            throw new NotImplementedException();
        }

        private static void ValidateCommonFields(
            string description,
            string category,
            ValidationResult result
        )
        {
            if (string.IsNullOrEmpty(description) || string.IsNullOrWhiteSpace(description))
                result.Errors.Add("Se requiere la descripción.");

            if (description?.Length > BrandConsts.MaxDescriptionLength)
                result.Errors.Add(
                    $"La descripción no puede tener más de {BrandConsts.MaxDescriptionLength} caracteres."
                );

            if (string.IsNullOrEmpty(category) || string.IsNullOrWhiteSpace(category))
                result.Errors.Add("Se requiere la categoría.");

            if (category?.Length > BrandConsts.MaxCategoryLength)
                result.Errors.Add(
                    $"La categoría no puede tener más de {BrandConsts.MaxCategoryLength} caracteres."
                );
        }
    }
}
