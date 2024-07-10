using InsanmarTec.Application.Models.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Models.Features
{
    public class ModelCreator : ITransientDependency
    {
        private readonly IModelRepository _modelRepository;
        private readonly IObjectMapper _objectMapper;

        public ModelCreator(IModelRepository modelRepository, IObjectMapper objectMapper)
        {
            _modelRepository = modelRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result> execute(CreateModelDto input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrEmpty(input.Name) || string.IsNullOrWhiteSpace(input.Name))
                result.Errors.Add("Se requiere el nombre.");

            if (input.Name?.Length > ModelConsts.MaxNameLength)
                result.Errors.Add($"El nombre no puede tener más de {ModelConsts.MaxNameLength}");

            if (!result.IsValid)
                return Result.Failure(string.Join(",", result.Errors));

            try
            {
                var model = _objectMapper.Map<Model>(input);
                await _modelRepository.CreateAsync(model);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
