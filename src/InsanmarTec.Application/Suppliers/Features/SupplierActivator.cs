using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Suppliers;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Suppliers.Features
{
    public class SuppliersActivator : ITransientDependency
    {
        private readonly ISuppliersRepository _suppliersRepository;

        public SuppliersActivator(ISuppliersRepository suppliersRepository) =>
            _suppliersRepository = suppliersRepository;

        public async Task<Result> Execute(EntityDto input)
        {
            try
            {
                await _suppliersRepository.Activate(input.Id);
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
