using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Models.Features
{
    public class ModelActivator : ITransientDependency
    {
        private readonly IModelRepository _modelRepository;

        public ModelActivator(IModelRepository modelRepository) =>
            _modelRepository = modelRepository;

        public async Task<Result> Execute(EntityDto input)
        {
            try
            {
                await _modelRepository.Activate(input.Id);
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
