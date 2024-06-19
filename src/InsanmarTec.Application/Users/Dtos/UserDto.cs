using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Users.Dtos
{
    public class UserDto : EntityDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
