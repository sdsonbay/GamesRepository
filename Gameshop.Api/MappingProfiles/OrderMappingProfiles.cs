using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class OrderMappingProfiles : Profile
{
    public OrderMappingProfiles()
    {
        CreateMap<GetAllOrdersRequest, GetAllOrdersQuery>();
        CreateMap<GetAllOrdersOutput, GetAllOrdersResponse>()
            .ForMember(dest => dest.Orders, src => src.MapFrom(x => x.Parameters));
        CreateMap<OrderDto, GetAllOrdersParametersOutput>()
            .ForMember(dest => dest.OrderStatus, src => src.MapFrom(x => x.OrderStatus));
        CreateMap<GetAllOrdersParametersOutput, OrderDto>()
            .ForMember(dest => dest.OrderStatus, src => src.MapFrom(x => x.OrderStatus));
        
        CreateMap<GetOrdersByOrderStatusRequest, GetOrdersByOrderStatusQuery>()
            .ForMember(dest => dest.OrderStatus, src => src.MapFrom(x => x.OrderStatus));
        CreateMap<GetOrdersByOrderStatusOutput, GetOrdersByOrderStatusResponse>()
            .ForMember(dest => dest.Orders, src => src.MapFrom(x => x.Parameters));
        CreateMap<OrderDto, GetOrdersByOrderStatusParametersOutput>();
        CreateMap<GetOrdersByOrderStatusParametersOutput, OrderDto>();
        
        CreateMap<GetOrderByIdRequest, GetOrderByIdQuery>();
        CreateMap<GetOrderByIdOutput, GetOrderByIdResponse>();
        CreateMap<OrderDto, GetOrderByIdOutput>();
        
        CreateMap<GetUserOfOrderByIdRequest, GetUserOfOrderByIdQuery>();
        CreateMap<GetUserOfOrderByIdArgs, GetUserOfOrderByIdRequest>();
        CreateMap<GetUserOfOrderByIdOutput, GetUserOfOrderByIdResponse>();
        CreateMap<UserDto, GetUserOfOrderByIdOutput>();
        CreateMap<GetUserOfOrderByIdOutput, UserDto>();
        
        CreateMap<GetGameOfOrderByIdRequest, GetGameOfOrderByIdQuery>();
        CreateMap<GetGameOfOrderByIdArgs, GetGameOfOrderByIdRequest>();
        CreateMap<GetGameOfOrderByIdOutput, GetGameOfOrderByIdResponse>();
        CreateMap<GameDto, GetGameOfOrderByIdOutput>();
        CreateMap<GetGameOfOrderByIdOutput, GameDto>();
        
        CreateMap<CheckOrderExistsByIdRequest, CheckOrderExistsByIdQuery>();
        CreateMap<CheckOrderExistsByIdOutput, CheckOrderExistsByIdResponse>();
        
        CreateMap<CreateNewOrderRequest, CreateNewOrderCommand>();
        CreateMap<CreateNewOrderOutput, CreateNewOrderResponse>();
        
        CreateMap<UpdateOrderByIdRequest, UpdateOrderByIdCommand>();
        CreateMap<UpdateOrderByIdOutput, UpdateOrderByIdResponse>();
        
        CreateMap<DeleteOrderByIdRequest, DeleteOrderByIdCommand>();
        CreateMap<DeleteOrderByIdOutput, DeleteOrderByIdResponse>();
    }
}