using AutoMapper;
using InsanmarTec.Application.Models.Dtos;
using InsanmarTec.Domain.Models;

namespace InsanmarTec.Application.Models
{
    public class ModelMapProfile : Profile
    {
        public ModelMapProfile()
        {
            CreateMap<CreateModelDto, Model>();
            CreateMap<Model, ModelDto>();
        }
    }
}
