using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Suppliers.Dtos
{
    public class UpdateSuppliersDto : EntityDto
    {
        public string mail { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string address { get; set; } = null!;
    }
}
