using AutoMapper;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;

namespace Gameshop.Infrastructure.MappingProfiles;

public class CreditCardMappingProfiles : Profile
{
    public CreditCardMappingProfiles()
    {
        CreateMap<CreditCard, CreditCardDto>();
    }
}