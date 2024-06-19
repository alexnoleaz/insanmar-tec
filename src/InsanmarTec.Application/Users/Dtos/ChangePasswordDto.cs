using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Users.Dtos
{
    public class ChangePasswordDto : EntityDto
    {
        public string Password { get; set; } = null!;
    }
}
