using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<GetAllUsersOutput> GetAllUsersAsync(CancellationToken cancellationToken = default)
    {
        var users = await _userRepository.GetAllUsersAsync(cancellationToken);
        var result = _mapper.Map<List<UserDto>>(users);
        var mappedResult = _mapper.Map<List<GetAllUsersParametersOutput>>(result);
        var output = new GetAllUsersOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetUserByIdOutput> GetUserByIdAsync(GetUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetUserByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<UserDto>(user);
        var mappedResult = _mapper.Map<GetUserByIdOutput>(result);
        var output = new GetUserByIdOutput()
        {
            FirstName = mappedResult.FirstName,
            LastName = mappedResult.LastName,
            Username = mappedResult.Username,
            Email = mappedResult.Email,
            Password = mappedResult.Password,
            Addresses = mappedResult.Addresses,
            CreditCards = mappedResult.CreditCards,
            Orders = mappedResult.Orders,
            Games = mappedResult.Games
        };
        return output;
    }

    public async Task<GetUserByUsernameOutput> GetUserByUsernameAsync(GetUserByUsernameArgs args, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetUserByUsernameAsync(args.Username, cancellationToken);
        var result = _mapper.Map<UserDto>(user);
        var mappedResult = _mapper.Map<GetUserByUsernameOutput>(result);
        var output = new GetUserByUsernameOutput()
        {
            FirstName = mappedResult.FirstName,
            LastName = mappedResult.LastName,
            Username = mappedResult.Username,
            Email = mappedResult.Email,
            Password = mappedResult.Password,
            Addresses = mappedResult.Addresses,
            CreditCards = mappedResult.CreditCards,
            Orders = mappedResult.Orders,
            Games = mappedResult.Games
        };
        return output;
    }

    public async Task<GetUserByEmailOutput> GetUserByEmailAsync(GetUserByEmailArgs args, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetUserByEmailAsync(args.Email, cancellationToken);
        var result = _mapper.Map<UserDto>(user);
        var mappedResult = _mapper.Map<GetUserByEmailOutput>(result);
        var output = new GetUserByEmailOutput()
        {
            FirstName = mappedResult.FirstName,
            LastName = mappedResult.LastName,
            Username = mappedResult.Username,
            Email = mappedResult.Email,
            Password = mappedResult.Password,
            Addresses = mappedResult.Addresses,
            CreditCards = mappedResult.CreditCards,
            Orders = mappedResult.Orders,
            Games = mappedResult.Games
        };
        return output;
    }

    public async Task<GetUsersByFirstNameOutput> GetUsersByFirstNameAsync(GetUserByFirstNameArgs args, CancellationToken cancellationToken = default)
    {
        var users = await _userRepository.GetUsersByFirstNameAsync(args.FirstName, cancellationToken);
        var result = _mapper.Map<List<UserDto>>(users);
        var mappedResult = _mapper.Map<List<GetUsersByFirstNameParametersOutput>>(result);
        var output = new GetUsersByFirstNameOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetUsersByLastNameOutput> GetUsersByLastNameAsync(GetUserByLastNameArgs args, CancellationToken cancellationToken = default)
    {
        var users = await _userRepository.GetUsersByLastNameAsync(args.LastName, cancellationToken);
        var result = _mapper.Map<List<UserDto>>(users);
        var mappedResult = _mapper.Map<List<GetUsersByLastNameParametersOutput>>(result);
        var output = new GetUsersByLastNameOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetAddressesOfUserByIdOutput> GetAddressesOfUserByIdAsync(GetAddressesOfUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var addresses = await _userRepository.GetAddressesOfUserByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<AddressDto>>(addresses);
        var mappedResult = _mapper.Map<List<GetAddressesOfUserByIdParametersOutput>>(result);
        var output = new GetAddressesOfUserByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetCreditCardsOfUserByIdOutput> GetCreditCardsOfUserByIdAsync(GetCreditCardsOfUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var creditCards = await _userRepository.GetCreditCardsOfUserByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<CreditCardDto>>(creditCards);
        var mappedResult = _mapper.Map<List<GetCreditCardsOfUserByIdParametersOutput>>(result);
        var output = new GetCreditCardsOfUserByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetOrdersOfUserByIdOutput> GetOrdersOfUserByIdAsync(GetOrdersOfUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var orders = await _userRepository.GetOrdersOfUserByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<OrderDto>>(orders);
        var mappedResult = _mapper.Map<List<GetOrdersOfUserByIdParametersOutput>>(result);
        var output = new GetOrdersOfUserByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetGamesOfUserByIdOutput> GetGamesOfUserByIdAsync(GetGamesOfUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var games = await _userRepository.GetGamesOfUserByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<GameDto>>(games);
        var mappedResult = _mapper.Map<List<GetGamesOfUserByIdParametersOutput>>(result);
        var output = new GetGamesOfUserByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<CheckUserExistsByIdOutput> CheckUserExistsByIdAsync(CheckUserExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var userExists = await _userRepository.CheckUserExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckUserExistsByIdOutput()
        {
            UserExists = userExists
        };
        return output;
    }

    public async Task<CreateNewUserOutput> CreateNewUserAsync(CreateNewUserArgs args, CancellationToken cancellationToken = default)
    {
        var userCreated = await _userRepository.CreateNewUserAsync(args.User, cancellationToken);
        var output = new CreateNewUserOutput()
        {
            UserCreated = userCreated
        };
        return output;
    }

    public async Task<UpdateUserByIdOutput> UpdateUserByIdAsync(UpdateUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var userInDb = await _userRepository.GetUserByIdAsync(args.Id, cancellationToken);
        userInDb.FirstName = args.FirstName;
        userInDb.LastName = args.LastName;
        userInDb.Email = args.Email;
        userInDb.Username = args.Username;
        userInDb.Password = args.Password;
        var userUpdated = await _userRepository.UpdateUserByIdAsync(userInDb, cancellationToken);
        var output = new UpdateUserByIdOutput()
        {
            UserUpdated = userUpdated
        };
        return output;
    }

    public async Task<DeleteUserByIdOutput> DeleteUserByIdAsync(DeleteUserByIdArgs args, CancellationToken cancellationToken = default)
    {
        var userDeleted = await _userRepository.DeleteUserByIdAsync(args.Id, cancellationToken);
        var output = new DeleteUserByIdOutput()
        {
            UserDeleted = userDeleted
        };
        return output;
    }
}