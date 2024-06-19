using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Users.Features
{
    public class UserUpdater : ITransientDependency
    {
        private readonly IUserRepository _userRepository;
        private readonly IObjectMapper _objectMapper;

        public UserUpdater(IUserRepository userRepository, IObjectMapper objectMapper)
        {
            _userRepository = userRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<UserDto>> Execute(UpdateUserDto input)
        {
            var result = UserValidator.Validate(input);
            if (!result.IsValid)
                return Result<UserDto>.Failure(string.Join(",", result.Errors));

            try
            {
                var userDb = await _userRepository.GetAsync(input.Id);
                var userDto = _objectMapper.Map<UserDto>(
                    await _userRepository.UpdateAsync(_objectMapper.Map(input, userDb))
                );

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
