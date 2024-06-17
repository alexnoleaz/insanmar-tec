using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Brands.Features
{
    public class BrandGetter : ITransientDependency
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IObjectMapper _objectMapper;

        public BrandGetter(IBrandRepository brandRepository, IObjectMapper objectMapper)
        {
            _brandRepository = brandRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<BrandDto>> ExecuteAsync(EntityDto input)
        {
            try
            {
                var brandDb = await _brandRepository.GetAsync(input.Id);
                var brandDto = _objectMapper.Map<BrandDto>(brandDb);

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
