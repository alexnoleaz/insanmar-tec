using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Brands.Features
{
    public class BrandDeactivator : ITransientDependency
    {
        private readonly IBrandRepository _brandRepository;

        public BrandDeactivator(IBrandRepository brandRepository) =>
            _brandRepository = brandRepository;

        public async Task<Result> Execute(EntityDto input)
        {
            try
            {
                await _brandRepository.Deactivate(input.Id);
                return Result.Success();
            }
            catch (EntityNotFoundException ex)
            {
                return Result.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
