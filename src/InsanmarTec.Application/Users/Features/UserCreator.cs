using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Users.Features
{
    public class UserCreator : ITransientDependency
    {
        private readonly IUserRepository _userRepository;
        private readonly IObjectMapper _objectMapper;
        private readonly IPasswordHasher _passwordHasher;

        public UserCreator(
            IUserRepository userRepository,
            IObjectMapper objectMapper,
            IPasswordHasher passwordHasher
        )
        {
            _userRepository = userRepository;
            _objectMapper = objectMapper;
            _passwordHasher = passwordHasher;
        }

        public async Task<Result> Execute(CreateUserDto input)
        {
            var result = UserValidator.Validate(input);
            if (!result.IsValid)
                return Result.Failure(string.Join(",", result.Errors));

            try
            {
                input.Password = _passwordHasher.Hash(input.Password);
                var user = _objectMapper.Map<User>(input);
                await _userRepository.CreateAsync(user);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
