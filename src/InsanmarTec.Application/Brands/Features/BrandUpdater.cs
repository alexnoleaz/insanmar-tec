using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Brands.Features
{
    public class BrandUpdater : ITransientDependency
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IObjectMapper _objectMapper;

        public BrandUpdater(IBrandRepository brandRepository, IObjectMapper objectMapper)
        {
            _brandRepository = brandRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<BrandDto>> ExecuteAsync(UpdateBrandDto input)
        {
            var result = BrandValidator.Validate(input);
            if (!result.IsValid)
                return Result<BrandDto>.Failure(string.Join(",", result.Errors));

            try
            {
                var brand = _objectMapper.Map<Brand>(input);
                var brandDb = await _brandRepository.GetAsync(brand.Id);
                var brandDto = _objectMapper.Map<BrandDto>(
                    await _brandRepository.UpdateAsync(brandDb)
                );

                return Result<BrandDto>.Success(brandDto);
            }
            catch (EntityNotFoundException ex)
            {
                return Result<BrandDto>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result<BrandDto>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
