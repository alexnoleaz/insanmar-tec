using InsanmarTec.Application.Models.Dtos;
using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Models.Features
{
    public class ModelGetter : ITransientDependency
    {
        private readonly IModelRepository _modelRepository;
        private readonly IObjectMapper _objectMapper;

        public ModelGetter(IModelRepository modelRepository, IObjectMapper objectMapper)
        {
            _modelRepository = modelRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<ModelDto>> Execute(EntityDto input)
        {
            try
            {
                var modelDb = await _modelRepository.GetAsync(input.Id);
                var modelDto = _objectMapper.Map<ModelDto>(modelDb);

                return Result<ModelDto>.Success(modelDto);
            }
            catch (EntityNotFoundException ex)
            {
                return Result<ModelDto>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result<ModelDto>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
