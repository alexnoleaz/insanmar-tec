using InsanmarTec.Application.Suppliers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Suppliers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Brands.Features
{
    public class SupplierUpdater : ITransientDependency
    {
        private readonly ISuppliersRepository _brandRepository;
        private readonly IObjectMapper _objectMapper;

        public SupplierUpdater(ISuppliersRepository brandRepository, IObjectMapper objectMapper)
        {
            _brandRepository = brandRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<SuppliersDto>> Execute(UpdateSuppliersDto input)
        {
            var result = BrandValidator.Validate(input);
            if (!result.IsValid)
                return Result<SuppliersDto>.Failure(string.Join(",", result.Errors));

            try
            {
                var brandDb = await _brandRepository.GetAsync(input.Id);
                var brandDto = _objectMapper.Map<SuppliersDto>(
                    await _brandRepository.UpdateAsync(_objectMapper.Map(input, brandDb))
                );

                return Result<SuppliersDto>.Success(brandDto);
            }
            catch (EntityNotFoundException ex)
            {
                return Result<SuppliersDto>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result<SuppliersDto>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
