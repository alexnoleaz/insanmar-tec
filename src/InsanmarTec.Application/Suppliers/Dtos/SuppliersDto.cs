using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Suppliers.Dtos
{
    public class SuppliersDto : EntityDto
    {
        public string Name { get; set; } = null!;
        public string mail { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string address { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
