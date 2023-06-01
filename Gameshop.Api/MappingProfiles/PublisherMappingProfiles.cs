using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class PublisherMappingProfiles : Profile
{
    public PublisherMappingProfiles()
    {
        CreateMap<GetAllPublishersRequest, GetAllPublishersQuery>();
        CreateMap<GetAllPublishersOutput, GetAllPublishersResponse>()
            .ForMember(dest => dest.Publishers, src => src.MapFrom(x => x.Parameters));
        CreateMap<PublisherDto, GetAllPublishersParametersOutput>();
        CreateMap<GetAllPublishersParametersOutput, PublisherDto>();
        
        CreateMap<GetPublisherByIdRequest, GetPublisherByIdQuery>();
        CreateMap<GetPublisherByIdOutput, GetPublisherByIdResponse>();
        CreateMap<PublisherDto, GetPublisherByIdOutput>();
        
        CreateMap<GetPublisherByNameRequest, GetPublisherByNameQuery>();
        CreateMap<GetPublisherByNameOutput, GetPublisherByNameResponse>();
        CreateMap<PublisherDto, GetPublisherByNameOutput>();
        
        CreateMap<GetGamesOfPublisherByIdRequest, GetGamesOfPublisherByIdQuery>();
        CreateMap<GetGamesOfPublisherByIdArgs, GetGamesOfPublisherByIdRequest>();
        CreateMap<GetGamesOfPublisherByIdOutput, GetGamesOfPublisherByIdResponse>()
            .ForMember(dest => dest.Games, src => src.MapFrom(x => x.Parameters));
        CreateMap<GameDto, GetGamesOfPublisherByIdParametersOutput>();
        CreateMap<GetGamesOfPublisherByIdParametersOutput, GameDto>();
        
        CreateMap<CheckPublisherExistsByIdRequest, CheckPublisherExistsByIdQuery>();
        CreateMap<CheckPublisherExistsByIdOutput, CheckPublisherExistsByIdResponse>();
        
        CreateMap<CreateNewPublisherRequest, CreateNewPublisherCommand>();
        CreateMap<CreateNewPublisherOutput, CreateNewPublisherResponse>();
        
        CreateMap<UpdatePublisherByIdRequest, UpdatePublisherByIdCommand>();
        CreateMap<UpdatePublisherByIdOutput, UpdatePublisherByIdResponse>();
        
        CreateMap<DeletePublisherByIdRequest, DeletePublisherByIdCommand>();
        CreateMap<DeletePublisherByIdOutput, DeletePublisherByIdResponse>();
    }
}