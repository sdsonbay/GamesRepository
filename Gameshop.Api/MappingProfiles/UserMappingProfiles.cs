using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class UserMappingProfiles : Profile
{
    public UserMappingProfiles()
    {
        CreateMap<GetAllUsersRequest, GetAllUsersQuery>();
        CreateMap<GetAllUsersOutput, GetAllUsersResponse>()
            .ForMember(dest => dest.Users, src => src.MapFrom(x => x.Parameters));
        CreateMap<UserDto, GetAllUsersParametersOutput>();
        CreateMap<GetAllUsersParametersOutput, UserDto>();

        CreateMap<GetUserByIdRequest, GetUserByIdQuery>();
        CreateMap<GetUserByIdOutput, GetUserByIdResponse>();
        CreateMap<UserDto, GetUserByIdOutput>();
        
        CreateMap<GetUserByUsernameRequest, GetUserByUsernameQuery>();
        CreateMap<GetUserByUsernameOutput, GetUserByUsernameResponse>();
        CreateMap<UserDto, GetUserByUsernameOutput>();
        
        CreateMap<GetUserByEmailRequest, GetUserByEmailQuery>();
        CreateMap<GetUserByEmailOutput, GetUserByEmailResponse>();
        CreateMap<UserDto, GetUserByEmailOutput>();
        
        CreateMap<GetUserByFirstNameRequest, GetUserByFirstNameQuery>();
        CreateMap<GetUserByFirstNameArgs, GetUserByFirstNameRequest>();
        CreateMap<GetUsersByFirstNameOutput, GetUserByFirstNameResponse>()
            .ForMember(dest => dest.Users, src => src.MapFrom(x => x.Parameters));
        CreateMap<UserDto, GetUsersByFirstNameParametersOutput>();
        CreateMap<GetUsersByFirstNameParametersOutput, UserDto>();
        
        CreateMap<GetUserByLastNameRequest, GetUserByLastNameQuery>();
        CreateMap<GetUserByLastNameQuery, GetUserByLastNameRequest>();
        CreateMap<GetUsersByLastNameOutput, GetUserByLastNameResponse>()
            .ForMember(dest => dest.Users, src => src.MapFrom(x => x.Parameters));
        CreateMap<UserDto, GetUsersByLastNameParametersOutput>();
        CreateMap<GetUsersByLastNameParametersOutput, UserDto>();
        
        CreateMap<GetAddressesOfUserByIdRequest, GetAddressesOfUserByIdQuery>();
        CreateMap<GetAddressesOfUserByIdQuery, GetAddressesOfUserByIdRequest>();
        CreateMap<GetAddressesOfUserByIdOutput, GetAddressesOfUserByIdResponse>()
            .ForMember(dest => dest.Addressses, src => src.MapFrom(x => x.Parameters));
        CreateMap<AddressDto, GetAddressesOfUserByIdParametersOutput>();
        CreateMap<GetAddressesOfUserByIdParametersOutput, AddressDto>();

        CreateMap<GetCreditCardsOfUserByIdRequest, GetCreditCardsOfUserByIdQuery>();
        CreateMap<GetCreditCardsOfUserByIdQuery, GetCreditCardsOfUserByIdRequest>();
        CreateMap<GetCreditCardsOfUserByIdOutput, GetCreditCardsOfUserByIdResponse>()
            .ForMember(dest => dest.CreditCards, src => src.MapFrom(x => x.Parameters));
        CreateMap<CreditCardDto, GetCreditCardsOfUserByIdParametersOutput>();
        CreateMap<GetCreditCardsOfUserByIdParametersOutput, CreditCardDto>();

        CreateMap<GetOrdersOfUserByIdRequest, GetOrdersOfUserByIdQuery>();
        CreateMap<GetOrdersOfUserByIdQuery, GetOrdersOfUserByIdRequest>();
        CreateMap<GetOrdersOfUserByIdOutput, GetOrdersOfUserByIdResponse>()
            .ForMember(dest => dest.Orders, src => src.MapFrom(x => x.Parameters));
        CreateMap<OrderDto, GetOrdersOfUserByIdParametersOutput>();
        CreateMap<GetOrdersOfUserByIdParametersOutput, OrderDto>();
        
        CreateMap<GetGamesOfUserByIdRequest, GetGamesOfUserByIdQuery>();
        CreateMap<GetGamesOfUserByIdQuery, GetGamesOfUserByIdRequest>();
        CreateMap<GetGamesOfUserByIdOutput, GetGamesOfUserByIdResponse>()
            .ForMember(dest => dest.Games, src => src.MapFrom(x => x.Parameters));
        CreateMap<GameDto, GetGamesOfUserByIdParametersOutput>();
        CreateMap<GetGamesOfUserByIdParametersOutput, GameDto>();
        
        CreateMap<CheckUserExistsByIdRequest, CheckUserExistsByIdQuery>();
        CreateMap<CheckUserExistsByIdOutput, CheckUserExistsByIdResponse>();
        
        CreateMap<CreateNewUserRequest, CreateNewUserCommand>();
        CreateMap<CreateNewUserOutput, CreateNewUserResponse>();
        
        CreateMap<UpdateUserByIdRequest, UpdateUserByIdCommand>();
        CreateMap<UpdateUserByIdOutput, UpdateUserByIdResponse>();
        
        CreateMap<DeleteUserByIdRequest, DeleteUserByIdCommand>();
        CreateMap<DeleteUserByIdOutput, DeleteUserByIdResponse>();
    }
}