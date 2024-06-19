using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Roles.Dtos
{
    public class RoleDto : EntityDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
