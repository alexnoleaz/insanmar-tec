using InsanmarTec.Application.Models.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Models.Features
{
    public class ModelsGetter : ITransientDependency
    {
        private readonly IModelRepository _modelRepository;
        private readonly IObjectMapper _objectMapper;

        public ModelsGetter(IModelRepository modelRepository, IObjectMapper objectMapper)
        {
            _modelRepository = modelRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<IEnumerable<ModelDto>>> Execute()
        {
            try
            {
                var modelsDb = await _modelRepository.GetAllAsync();
                var modelsDto = _objectMapper.Map<List<ModelDto>>(modelsDb);

                return Result<IEnumerable<ModelDto>>.Success(modelsDto);
            }

            catch (Exception ex)
            {
                return Result<IEnumerable<ModelDto>>.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
