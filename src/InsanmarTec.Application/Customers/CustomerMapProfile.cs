using AutoMapper;
using InsanmarTec.Application.Customers.Dtos;
using InsanmarTec.Domain.Customers;

namespace InsanmarTec.Application.Customers
{
    public class CustomerMapProfile : Profile
    {
        public CustomerMapProfile()
        {
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<UpdateCustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
