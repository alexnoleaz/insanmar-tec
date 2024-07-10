using InsanmarTec.Application.Suppliers.Dtos;
using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Suppliers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Suppliers.Features
{
    public class SupplierGetter : ITransientDependency
    {
        private readonly ISuppliersRepository _supplierRepository;
        private readonly IObjectMapper _objectMapper;

        public SupplierGetter(ISuppliersRepository supplierRepository, IObjectMapper objectMapper)
        {
            _supplierRepository = supplierRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<SuppliersDto>> Execute(EntityDto input)
        {
            try
            {
                var supplierDb = await _supplierRepository.GetAsync(input.Id);
                var supplierDto = _objectMapper.Map<SuppliersDto>(supplierDb);

                return Result<SuppliersDto>.Success(supplierDto);
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
