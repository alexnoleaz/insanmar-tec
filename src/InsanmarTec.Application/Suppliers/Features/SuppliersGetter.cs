using InsanmarTec.Application.Suppliers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Suppliers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Supplierss.Features
{
    public class BrandsGetter : ITransientDependency
    {
        private readonly ISuppliersRepository _brandRepository;
        private readonly IObjectMapper _objectMapper;

        public BrandsGetter(ISuppliersRepository brandRepository, IObjectMapper objectMapper)
        {
            _brandRepository = brandRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<IEnumerable<SuppliersDto>>> Execute()
        {
            try
            {
                var brandsDb = await _brandRepository.GetAllAsync();
                var brandsDto = _objectMapper.Map<List<SuppliersDto>>(brandsDb);

                return Result<IEnumerable<SuppliersDto>>.Success(brandsDto);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<SuppliersDto>>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
