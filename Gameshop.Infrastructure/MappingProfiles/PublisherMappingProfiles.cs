using AutoMapper;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;

namespace Gameshop.Infrastructure.MappingProfiles;

public class PublisherMappingProfiles : Profile
{
    public PublisherMappingProfiles()
    {
        CreateMap<Publisher, PublisherDto>();
    }
}