using AutoMapper;
using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Domain.Brands;

namespace InsanmarTec.Application.Brands
{
    public class BrandMapProfile : Profile
    {
        public BrandMapProfile()
        {
            CreateMap<CreateBrandDto, Brand>();
            CreateMap<UpdateBrandDto, Brand>();
            CreateMap<Brand, BrandDto>();
        }
    }
}
