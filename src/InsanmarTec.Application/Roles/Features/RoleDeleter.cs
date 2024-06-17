using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Roles;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Roles.Features
{
    public class RoleDeleter : ITransientDependency
    {
        private readonly IRoleRepository _roleRepository;

        public RoleDeleter(IRoleRepository roleRepository) => _roleRepository = roleRepository;

        public async Task<Result> ExecuteAsync(EntityDto input)
        {
            try
            {
                var roleDb = await _roleRepository.GetAsync(input.Id);
                await _roleRepository.DeleteAsync(roleDb.Id);
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
