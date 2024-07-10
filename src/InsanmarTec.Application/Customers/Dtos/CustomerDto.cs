using InsanmarTec.Application.Shared.Dtos;

namespace InsanmarTec.Application.Customers.Dtos
{
    public class CustomerDto : EntityDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
