using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Users.Features
{
    public class PasswordChanger
    {
        private readonly IUserRepository _userRepository;
        private readonly IObjectMapper _objectMapper;

        public PasswordChanger(IUserRepository userRepository, IObjectMapper objectMapper)
        {
            _userRepository = userRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<UserDto>> Execute(ChangePasswordDto input)
        {
            if (string.IsNullOrEmpty(input.Password) || string.IsNullOrWhiteSpace(input.Password))
                return Result<UserDto>.Failure("Se require la contraseña.");

            try
            {
                var user = await _userRepository.ChangePassword(input.Id, input.Password);
                var userDto = _objectMapper.Map<UserDto>(user);
                return Result<UserDto>.Success(userDto);
            }
            catch (EntityNotFoundException ex)
            {
                return Result<UserDto>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result<UserDto>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
