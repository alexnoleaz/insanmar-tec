using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Brands.Dtos
{
    public class BrandDto : EntityDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
