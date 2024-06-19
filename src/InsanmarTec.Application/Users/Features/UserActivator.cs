using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Users.Features
{
    public class UserActivator
    {
        private readonly IUserRepository _userRepository;

        public UserActivator(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<Result> Execute(EntityDto input)
        {
            try
            {
                await _userRepository.Activate(input.Id);
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
