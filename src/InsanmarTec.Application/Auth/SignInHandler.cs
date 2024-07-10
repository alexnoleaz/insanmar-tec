using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Auth
{
    public class SignInHandler : ITransientDependency
    {
        private readonly IUserRepository _userRepository;
        private readonly IObjectMapper _objectMapper;
        private readonly IPasswordHasher _passwordHasher;

        public SignInHandler(
            IUserRepository userRepository,
            IObjectMapper objectMapper,
            IPasswordHasher passwordHasher
        )
        {
            _userRepository = userRepository;
            _objectMapper = objectMapper;
            _passwordHasher = passwordHasher;
        }

        public async Task<Result<UserDto>> Execute(SignInDto input)
        {
            var result = new ValidationResult();
            var responseMessage = "Nombre de usuario o contraseña incorrecta.";

            if (string.IsNullOrEmpty(input.Username) || string.IsNullOrWhiteSpace(input.Username))
                result.Errors.Add("Se requiere el nombre de usuario.");

            if (input.Username?.Length > UserConsts.MaxUsernameLength)
                result.Errors.Add(
                    $"El nombre de usuario no puede tener más de {UserConsts.MaxUsernameLength} caracteres."
                );

            if (string.IsNullOrEmpty(input.Password) || string.IsNullOrWhiteSpace(input.Password))
                result.Errors.Add("Se requiere la contraseña.");

            if (input.Password?.Length > UserConsts.MaxPasswordLength)
                result.Errors.Add(
                    $"La contraseña no puede tener más de {UserConsts.MaxPasswordLength} caracteres."
                );

            if (!result.IsValid)
                return Result<UserDto>.Failure(string.Join(",", result.Errors));

            try
            {
                var userDb = await _userRepository.Get(u => u.Username == input.Username!);
                if (!_passwordHasher.Compare(userDb.Password, input.Password!))
                    return Result<UserDto>.Failure(responseMessage);

                var userDto = _objectMapper.Map<UserDto>(userDb);

                return Result<UserDto>.Success(userDto);
            }
            catch (EntityNotFoundException)
            {
                return Result<UserDto>.Failure(responseMessage);
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
