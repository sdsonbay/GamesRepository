using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Api.MappingProfiles;

public class CategoryMappingProfiles : Profile
{
    public CategoryMappingProfiles()
    {
        CreateMap<GetAllCategoriesRequest, GetAllCategoriesQuery>();
        CreateMap<GetAllCategoriesOutput, GetAllCategoriesResponse>()
            .ForMember(dest => dest.Categories, src => src.MapFrom(x => x.Parameters));
        CreateMap<CategoryDto, GetAllCategoriesParametersOutput>();
        CreateMap<GetAllCategoriesParametersOutput, CategoryDto>();
        
        CreateMap<GetCategoryByIdRequest, GetCategoryByIdQuery>();
        CreateMap<GetCategoryByIdOutput, GetCategoryByIdResponse>();
        CreateMap<CategoryDto, GetCategoryByIdOutput>();
        
        CreateMap<GetCategoryByNameRequest, GetCategoryByNameQuery>();
        CreateMap<GetCategoryByNameOutput, GetCategoryByNameResponse>();
        CreateMap<CategoryDto, GetCategoryByNameOutput>();
        
        CreateMap<GetGamesOfCategoryByIdRequest, GetGamesOfCategoryByIdQuery>();
        CreateMap<GetGamesOfCategoryByIdArgs, GetGamesOfCategoryByIdRequest>();
        CreateMap<GetGamesOfCategoryByIdOutput, GetGamesOfCategoryByIdResponse>()
            .ForMember(dest => dest.Games, src => src.MapFrom(x => x.Parameters));
        CreateMap<GameDto, GetGamesOfCategoryByIdParametersOutput>();
        CreateMap<GetGamesOfCategoryByIdParametersOutput, GameDto>();
        
        CreateMap<CheckCategoryExistsByIdRequest, CheckCategoryExistsByIdQuery>();
        CreateMap<CheckCategoryExistsByIdOutput, CheckCategoryExistsByIdResponse>();
        
        CreateMap<CreateNewCategoryRequest, CreateNewCategoryCommand>();
        CreateMap<CreateNewCategoryOutput, CreateNewCategoryResponse>();
        
        CreateMap<UpdateCategoryByIdRequest, UpdateCategoryByIdCommand>();
        CreateMap<UpdateCategoryByIdOutput, UpdateCategoryByIdResponse>();
        
        CreateMap<DeleteCategoryByIdRequest, DeleteCategoryByIdCommand>();
        CreateMap<DeleteCategoryByIdOutput, DeleteCategoryByIdResponse>();
    }
}