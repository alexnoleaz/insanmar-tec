using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Brands.Features
{
    public class BrandCreator : ITransientDependency
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IObjectMapper _objectMapper;

        public BrandCreator(IBrandRepository brandRepository, IObjectMapper objectMapper)
        {
            _brandRepository = brandRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result> Execute(CreateSuppliersDto input)
        {
            var result = BrandValidator.Validate(input);
            if (!result.IsValid)
                return Result.Failure(string.Join(",", result.Errors));

            try
            {
                var brand = _objectMapper.Map<Brand>(input);
                await _brandRepository.CreateAsync(brand);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
