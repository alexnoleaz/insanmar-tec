using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Customers.Dtos
{
    public class UpdateCustomerDto : EntityDto
    {
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
