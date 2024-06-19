using AutoMapper;
using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Auth.Users;

namespace InsanmarTec.Application.Users
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<ChangePasswordDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
