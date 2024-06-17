using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Roles.Dtos
{
    public class UpdateRoleDto : EntityDto
    {
        public string Description { get; set; } = null!;
    }
}
