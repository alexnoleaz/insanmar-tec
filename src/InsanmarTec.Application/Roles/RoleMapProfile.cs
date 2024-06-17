using AutoMapper;
using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Domain.Roles;

namespace InsanmarTec.Application.Roles
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();
            CreateMap<Role, RoleDto>();
        }
    }
}
