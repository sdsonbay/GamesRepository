using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;
    private readonly IMapper _mapper;

    public GameService(IGameRepository gameRepository, IMapper mapper)
    {
        _gameRepository = gameRepository;
        _mapper = mapper;
    }

    public async Task<GetAllGamesOutput> GetAllGamesAsync(CancellationToken cancellationToken = default)
    {
        var games = await _gameRepository.GetAllGamesAsync(cancellationToken);
        var result = _mapper.Map<List<GameDto>>(games);
        var mappedResult = _mapper.Map<List<GetAllGamesParametersOutput>>(result);
        var output = new GetAllGamesOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetGameByIdOutput> GetGameByIdAsync(GetGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var game = await _gameRepository.GetGameByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<GameDto>(game);
        var output = new GetGameByIdOutput()
        {
            Name = result.Name,
            Description = result.Description,
            Price = result.Price,
            ReleaseDate = result.ReleaseDate,
            PublisherId = result.PublisherId,
            CategoryId = result.CategoryId
        };
        return output;
    }

    public async Task<GetGameByNameOutput> GetGameByNameAsync(GetGameByNameArgs args, CancellationToken cancellationToken = default)
    {
        var game = await _gameRepository.GetGameByNameAsync(args.Name, cancellationToken);
        var result = _mapper.Map<GameDto>(game);
        var output = new GetGameByNameOutput()
        {
            Name = result.Name,
            Description = result.Description,
            Price = result.Price,
            ReleaseDate = result.ReleaseDate,
            PublisherId = result.PublisherId,
            CategoryId = result.CategoryId
        };
        return output;
    }

    public async Task<GetPublisherOfGameByIdOutput> GetPublisherOfGameByIdAsync(GetPublisherOfGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var publisher = await _gameRepository.GetPublisherOfGameByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<PublisherDto>(publisher);
        var output = new GetPublisherOfGameByIdOutput()
        {
            Name = result.Name,
            Games = result.Games
        };
        return output;
    }

    public async Task<GetCategoryOfGameByIdOutput> GetCategoryOfGameByIdAsync(GetCategoryOfGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var category = await _gameRepository.GetCategoryOfGameByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<CategoryDto>(category);
        var output = new GetCategoryOfGameByIdOutput()
        {
            Name = result.Name,
            Games = result.Games
        };
        return output;
    }

    public async Task<GetUsersOfGameByIdOutput> GetUsersOfGameByIdAsync(GetUsersOfGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var users = await _gameRepository.GetUsersOfGameByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<UserDto>>(users);
        var mappedResult = _mapper.Map<List<GetUsersOfGameByIdParametersOutput>>(result);
        var output = new GetUsersOfGameByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetOrdersOfGameByIdOutput> GetOrdersOfGameByIdAsync(GetOrdersOfGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var orders = await _gameRepository.GetOrdersOfGameByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<OrderDto>>(orders);
        var mappedResult = _mapper.Map<List<GetOrdersOfGameByIdParametersOutput>>(result);
        var output = new GetOrdersOfGameByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<CheckGameExistsByIdOutput> CheckGameExistsByIdAsync(CheckGameExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var gameExists = await _gameRepository.CheckGameExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckGameExistsByIdOutput()
        {
            GameExists = gameExists
        };
        return output;
    }

    public async Task<CreateNewGameOutput> CreateNewGameAsync(CreateNewGameArgs args, CancellationToken cancellationToken = default)
    {
        var gameCreated = await _gameRepository.CreateNewGameAsync(args.Game, cancellationToken);
        var output = new CreateNewGameOutput()
        {
            GameCreated = gameCreated
        };
        return output;
    }

    public async Task<UpdateGameByIdOutput> UpdateGameByIdAsync(UpdateGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var gameInDb = await _gameRepository.GetGameByIdAsync(args.Id, cancellationToken);
        gameInDb.Name = args.Name;
        gameInDb.Description = args.Description;
        gameInDb.Price = args.Price;
        gameInDb.ReleaseDate = args.ReleaseDate;
        gameInDb.PublisherId = args.PublisherId;
        gameInDb.CategoryId = args.CategoryId;
        var gameUpdated = await _gameRepository.UpdateGameByIdAsync(gameInDb, cancellationToken);
        var output = new UpdateGameByIdOutput()
        {
            GameUpdated = gameUpdated
        };
        return output;
    }

    public async Task<DeleteGameByIdOutput> DeleteGameByIdAsync(DeleteGameByIdArgs args, CancellationToken cancellationToken = default)
    {
        var gameDeleted = await _gameRepository.DeleteGameByIdAsync(args.Id, cancellationToken);
        var output = new DeleteGameByIdOutput()
        {
            GameDeleted = gameDeleted
        };
        return output;
    }
}