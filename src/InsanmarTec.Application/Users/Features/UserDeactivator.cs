using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Users.Features
{
    public class UserDeactivator
    {
        private readonly IUserRepository _userRepository;

        public UserDeactivator(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<Result> Execute(EntityDto input)
        {
            try
            {
                await _userRepository.Deactivate(input.Id);
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
