using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Enums;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class AddressMappingProfiles : Profile
{
    public AddressMappingProfiles()
    {
        CreateMap<AddressType, Models.Enums.AddressType>();
        CreateMap<OrderStatus, Models.Enums.OrderStatus>();
            
        CreateMap<GetAllAddressesRequest, GetAllAddressesQuery>();
        CreateMap<GetAllAddressesOutput, GetAllAddressesResponse>()
            .ForMember(dest => dest.Addressses, src => src.MapFrom(x => x.Parameters));
        CreateMap<AddressDto, GetAllAddressesParametersOutput>()
            .ForMember(dest => dest.AddressType, src => src.MapFrom(x => x.AddressType));
        CreateMap<GetAllAddressesParametersOutput, AddressDto>()
            .ForMember(dest => dest.AddressType, src => src.MapFrom(x => x.AddressType));
        
        CreateMap<GetAddressesByCountryRequest, GetAddressesByCountryQuery>();
        CreateMap<GetAddressesByCountryOutput, GetAddressesByCountryResponse>()
            .ForMember(dest => dest.Addresses, src => src.MapFrom(x => x.Parameters));
        CreateMap<AddressDto, GetAddressesByCountryParametersOutput>();
        CreateMap<GetAddressesByCountryParametersOutput, AddressDto>();
        
        CreateMap<GetAddressesByCityRequest, GetAddressesByCityQuery>();
        CreateMap<GetAddressesByCityOutput, GetAddressesByCityResponse>()
            .ForMember(dest => dest.Addresses, src => src.MapFrom(x => x.Parameters));
        CreateMap<AddressDto, GetAddressesByCityParametersOutput>();
        CreateMap<GetAddressesByCityParametersOutput, AddressDto>();
        
        CreateMap<GetAddressByIdRequest, GetAddressByIdQuery>();
        CreateMap<GetAddressByIdOutput, GetAddressByIdResponse>();
        CreateMap<AddressDto, GetAddressByIdOutput>();
        
        CreateMap<GetUserOfAddressByIdRequest, GetUserOfAddressByIdQuery>();
        CreateMap<GetUserOfAddressByIdArgs, GetUserOfAddressByIdRequest>();
        CreateMap<GetUserOfAddressByIdOutput, GetUserOfAddressByIdResponse>();
        CreateMap<UserDto, GetUserOfAddressByIdOutput>();
        CreateMap<GetUserOfAddressByIdOutput, UserDto>();
        
        CreateMap<CheckAddressExistsByIdRequest, CheckAddressExistsByIdQuery>();
        CreateMap<CheckAddressExistsByIdOutput, CheckAddressExistsByIdResponse>();
        
        CreateMap<CreateNewAddressRequest, CreateNewAddressCommand>();
        CreateMap<CreateNewAddressOutput, CreateNewAddressResponse>();
        
        CreateMap<UpdateAddressByIdRequest, UpdateAddressByIdCommand>();
        CreateMap<UpdateAddressByIdOutput, UpdateAddressByIdResponse>();
        
        CreateMap<DeleteAddressByIdRequest, DeleteAddressByIdCommand>();
        CreateMap<DeleteAddressByIdOutput, DeleteAddressByIdResponse>();
    }
}