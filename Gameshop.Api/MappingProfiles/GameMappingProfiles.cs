using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class GameMappingProfiles : Profile
{
    public GameMappingProfiles()
    {
        CreateMap<GetAllGamesRequest, GetAllGamesQuery>();
        CreateMap<GetAllGamesOutput, GetAllGamesResponse>()
            .ForMember(dest => dest.Games, src => src.MapFrom(x => x.Parameters));
        CreateMap<GameDto, GetAllGamesParametersOutput>();
        CreateMap<GetAllGamesParametersOutput, GameDto>();
        
        CreateMap<GetGameByIdRequest, GetGameByIdQuery>();
        CreateMap<GetGameByIdOutput, GetGameByIdResponse>();
        CreateMap<GameDto, GetGameByIdOutput>();
        
        CreateMap<GetGameByNameRequest, GetGameByNameQuery>();
        CreateMap<GetGameByNameOutput, GetGameByNameResponse>();
        CreateMap<GameDto, GetGameByNameOutput>();
        
        CreateMap<GetPublisherOfGameByIdRequest, GetPublisherOfGameByIdQuery>();
        CreateMap<GetPublisherOfGameByIdArgs, GetPublisherOfGameByIdQuery>();
        CreateMap<GetPublisherOfGameByIdOutput, GetPublisherOfGameByIdResponse>();
        CreateMap<PublisherDto, GetPublisherOfGameByIdOutput>();
        CreateMap<GetPublisherOfGameByIdOutput, PublisherDto>();
        
        CreateMap<GetCategoryOfGameByIdRequest, GetCategoryOfGameByIdQuery>();
        CreateMap<GetCategoryOfGameByIdArgs, GetCategoryOfGameByIdRequest>();
        CreateMap<GetCategoryOfGameByIdOutput, GetCategoryOfGameByIdResponse>();
        CreateMap<CategoryDto, GetCategoryOfGameByIdOutput>();
        CreateMap<GetCategoryOfGameByIdOutput, CategoryDto>();
        
        CreateMap<GetUsersOfGameByIdRequest, GetUsersOfGameByIdQuery>();
        CreateMap<GetUsersOfGameByIdArgs, GetUsersOfGameByIdRequest>();
        CreateMap<GetUsersOfGameByIdOutput, GetUsersOfGameByIdResponse>()
            .ForMember(dest => dest.Users, src => src.MapFrom(x => x.Parameters));
        CreateMap<UserDto, GetUsersOfGameByIdParametersOutput>();
        CreateMap<GetUsersOfGameByIdParametersOutput, UserDto>();
        
        CreateMap<GetOrdersOfGameByIdRequest, GetOrdersOfGameByIdQuery>();
        CreateMap<GetOrdersOfGameByIdArgs, GetOrdersOfGameByIdRequest>();
        CreateMap<GetOrdersOfGameByIdOutput, GetOrdersOfGameByIdResponse>()
            .ForMember(dest => dest.Orders, src => src.MapFrom(x => x.Parameters));
        CreateMap<OrderDto, GetOrdersOfGameByIdParametersOutput>();
        CreateMap<GetOrdersOfGameByIdParametersOutput, OrderDto>();
        
        CreateMap<CheckGameExistsByIdRequest, CheckGameExistsByIdQuery>();
        CreateMap<CheckGameExistsByIdOutput, CheckGameExistsByIdResponse>();
        
        CreateMap<CreateNewGameRequest, CreateNewGameCommand>();
        CreateMap<CreateNewGameOutput, CreateNewGameResponse>();
        
        CreateMap<UpdateGameByIdRequest, UpdateGameByIdCommand>();
        CreateMap<UpdateGameByIdOutput, UpdateGameByIdResponse>();
        
        CreateMap<DeleteGameByIdRequest, DeleteGameByIdCommand>();
        CreateMap<DeleteGameByIdOutput, DeleteGameByIdResponse>();
    }
}