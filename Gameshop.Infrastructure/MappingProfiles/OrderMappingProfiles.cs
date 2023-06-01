using AutoMapper;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;

namespace Gameshop.Infrastructure.MappingProfiles;

public class OrderMappingProfiles : Profile
{
    public OrderMappingProfiles()
    {
        CreateMap<Order, OrderDto>();
    }
}