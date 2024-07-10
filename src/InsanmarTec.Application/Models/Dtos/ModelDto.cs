using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Models.Dtos
{
    public class ModelDto : EntityDto
    {
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
