using AutoMapper;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;

namespace Gameshop.Infrastructure.MappingProfiles;

public class GameMappingProfiles : Profile
{
    public GameMappingProfiles()
    {
        CreateMap<Game, GameDto>();
    }
}