using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Brands.Dtos
{
    public class UpdateBrandDto : EntityDto
    {
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
