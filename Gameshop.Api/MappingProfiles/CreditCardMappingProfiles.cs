using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class CreditCardMappingProfiles : Profile
{
    public CreditCardMappingProfiles()
    {
        CreateMap<GetAllCreditCardsRequest, GetAllCreditCardsQuery>();
        CreateMap<GetAllCreditCardsOutput, GetAllCreditCardsResponse>()
            .ForMember(dest => dest.CreditCards, src => src.MapFrom(x => x.Parameters));
        CreateMap<CreditCardDto, GetAllCreditCardsParametersOutput>();
        CreateMap<GetAllCreditCardsParametersOutput, CreditCardDto>();
        
        CreateMap<GetCreditCardByIdRequest, GetCreditCardByIdQuery>();
        CreateMap<GetCreditCardByIdOutput, GetCreditCardByIdResponse>();
        CreateMap<CreditCardDto, GetCreditCardByIdOutput>();
        
        CreateMap<GetUserOfCreditCardByIdRequest, GetUserOfCreditCardByIdQuery>();
        CreateMap<GetUserOfCreditCardByIdArgs, GetUserOfCreditCardByIdRequest>();
        CreateMap<GetUserOfCreditCardByIdOutput, GetUserOfCreditCardByIdResponse>();
        CreateMap<UserDto, GetUserOfCreditCardByIdOutput>();
        CreateMap<GetUserOfCreditCardByIdOutput, UserDto>();
        
        CreateMap<CheckCreditCardExistsByIdRequest, CheckCreditCardExistsByIdQuery>();
        CreateMap<CheckCreditCardExistsByIdOutput, CheckCreditCardExistsByIdResponse>();
        
        CreateMap<CreateNewCreditCardRequest, CreateNewCreditCardCommand>();
        CreateMap<CreateNewCreditCardOutput, CreateNewCreditCardResponse>();
        
        CreateMap<UpdateCreditCardByIdRequest, UpdateCreditCardByIdCommand>();
        CreateMap<UpdateCreditCardByIdOutput, UpdateCreditCardByIdResponse>();
        
        CreateMap<DeleteCreditCardByIdRequest, DeleteCreditCardByIdCommand>();
        CreateMap<DeleteCreditCardByIdOutput, DeleteCreditCardByIdResponse>();
    }
}