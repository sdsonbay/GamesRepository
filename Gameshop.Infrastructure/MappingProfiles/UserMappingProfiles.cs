using AutoMapper;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;

namespace Gameshop.Infrastructure.MappingProfiles;

public class UserMappingProfiles : Profile
{
    public UserMappingProfiles()
    {
        CreateMap<User, UserDto>();
    }
}