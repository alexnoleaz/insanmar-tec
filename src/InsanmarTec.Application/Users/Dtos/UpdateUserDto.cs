using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Users.Dtos
{
    public class UpdateUserDto : EntityDto
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
