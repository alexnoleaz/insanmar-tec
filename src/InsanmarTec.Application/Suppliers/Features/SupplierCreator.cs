using InsanmarTec.Application.Suppliers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Suppliers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Application.Brands;

namespace InsanmarTec.Application.Suppliers.Features
{
    public class SupplierCreator : ITransientDependency
    {
        private readonly ISuppliersRepository _supplierRepository;
        private readonly IObjectMapper _objectMapper;

        public SupplierCreator(ISuppliersRepository supplierRepository, IObjectMapper objectMapper)
        {
            _supplierRepository = supplierRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result> Execute(CreateSuppliersDto input)
        {
            var result = SupplierValidator.Validate(input);
            if (!result.IsValid)
                return Result.Failure(string.Join(",", result.Errors));

            try
            {
                var Supplier = _objectMapper.Map<Supplier>(input);
                await _supplierRepository.CreateAsync(Supplier);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
