using AutoMapper;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;

namespace Gameshop.Infrastructure.MappingProfiles;

public class AddressMappingProfiles : Profile
{
    public AddressMappingProfiles()
    {
        CreateMap<Address, AddressDto>();
    }
}