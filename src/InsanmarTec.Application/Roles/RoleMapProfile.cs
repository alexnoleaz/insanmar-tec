using AutoMapper;
using InsanmarTec.Application.Roles.Dtos;
using InsanmarTec.Domain.Auth.Roles;

namespace InsanmarTec.Application.Roles
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            CreateMap<CreateRoleDto, Role>();
            CreateMap<Role, RoleDto>();
        }
    }
}
