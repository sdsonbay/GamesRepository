using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<GetAllCategoriesOutput> GetAllCategoriesAsync(CancellationToken cancellationToken = default)
    {
        var categories = await _categoryRepository.GetAllCategoriesAsync(cancellationToken);
        var result = _mapper.Map<List<CategoryDto>>(categories);
        var mappedResult = _mapper.Map<List<GetAllCategoriesParametersOutput>>(result);
        var output = new GetAllCategoriesOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetCategoryByIdOutput> GetCategoryByIdAsync(GetCategoryByIdArgs args, CancellationToken cancellationToken = default)
    {
        var category = await _categoryRepository.GetCategoryByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<CategoryDto>(category);
        var output = new GetCategoryByIdOutput()
        {
            Name = result.Name,
            Games = result.Games
        };
        return output;
    }

    public async Task<GetCategoryByNameOutput> GetCategoryByNameAsync(GetCategoryByNameArgs args, CancellationToken cancellationToken = default)
    {
        var category = await _categoryRepository.GetCategoryByNameAsync(args.Name, cancellationToken);
        var result = _mapper.Map<CategoryDto>(category);
        var output = new GetCategoryByNameOutput()
        {
            Name = result.Name,
            Games = result.Games
        };
        return output;
    }

    public async Task<GetGamesOfCategoryByIdOutput> GetGamesOfCategoryByIdAsync(GetGamesOfCategoryByIdArgs args, CancellationToken cancellationToken = default)
    {
        var games = await _categoryRepository.GetGamesOfCategoryByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<GameDto>>(games);
        var mappedResult = _mapper.Map<List<GetGamesOfCategoryByIdParametersOutput>>(result);
        var output = new GetGamesOfCategoryByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<CheckCategoryExistsByIdOutput> CheckCategoryExistsByIdAsync(CheckCategoryExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var categoryExists = await _categoryRepository.CheckCategoryExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckCategoryExistsByIdOutput()
        {
            CategoryExists = categoryExists
        };
        return output;
    }

    public async Task<CreateNewCategoryOutput> CreateNewCategoryAsync(CreateNewCategoryArgs args, CancellationToken cancellationToken = default)
    {
        var categoryCreated = await _categoryRepository.CreateNewCategoryAsync(args.Category, cancellationToken);
        var output = new CreateNewCategoryOutput()
        {
            CategoryCreated = categoryCreated
        };
        return output;
    }

    public async Task<UpdateCategoryByIdOutput> UpdateCategoryByIdAsync(UpdateCategoryByIdArgs args, CancellationToken cancellationToken = default)
    {
        var categoryInDb = await _categoryRepository.GetCategoryByIdAsync(args.Id, cancellationToken);
        categoryInDb.Name = args.Name;
        var categoryUpdated = await _categoryRepository.UpdateCategoryByIdAsync(categoryInDb, cancellationToken);
        var output = new UpdateCategoryByIdOutput()
        {
            CategoryUpdated = categoryUpdated
        };
        return output;
    }

    public async Task<DeleteCategoryByIdOutput> DeleteCategoryByIdAsync(DeleteCategoryByIdArgs args, CancellationToken cancellationToken = default)
    {
        var categoryDeleted = await _categoryRepository.DeleteCategoryByIdAsync(args.Id, cancellationToken);
        var output = new DeleteCategoryByIdOutput()
        {
            CategoryDeleted = categoryDeleted
        };
        return output;
    }
}