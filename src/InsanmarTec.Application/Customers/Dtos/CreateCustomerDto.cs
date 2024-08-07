﻿namespace InsanmarTec.Application.Customers.Dtos
{
    public class CreateCustomerDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Dni { get; set; } = null!;
    }
}
