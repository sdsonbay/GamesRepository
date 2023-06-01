using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface IUserService
{
    Task<GetAllUsersOutput> GetAllUsersAsync(CancellationToken cancellationToken = default);
    Task<GetUserByIdOutput> GetUserByIdAsync(GetUserByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetUserByUsernameOutput> GetUserByUsernameAsync(GetUserByUsernameArgs args, CancellationToken cancellationToken = default);
    Task<GetUserByEmailOutput> GetUserByEmailAsync(GetUserByEmailArgs args, CancellationToken cancellationToken = default);
    Task<GetUsersByFirstNameOutput> GetUsersByFirstNameAsync(GetUserByFirstNameArgs args, CancellationToken cancellationToken = default);
    Task<GetUsersByLastNameOutput> GetUsersByLastNameAsync(GetUserByLastNameArgs args, CancellationToken cancellationToken = default);
    Task<GetAddressesOfUserByIdOutput> GetAddressesOfUserByIdAsync(GetAddressesOfUserByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetCreditCardsOfUserByIdOutput> GetCreditCardsOfUserByIdAsync(GetCreditCardsOfUserByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetOrdersOfUserByIdOutput> GetOrdersOfUserByIdAsync(GetOrdersOfUserByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetGamesOfUserByIdOutput> GetGamesOfUserByIdAsync(GetGamesOfUserByIdArgs args, CancellationToken cancellationToken = default);
    Task<CheckUserExistsByIdOutput> CheckUserExistsByIdAsync(CheckUserExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewUserOutput> CreateNewUserAsync(CreateNewUserArgs args, CancellationToken cancellationToken = default);
    Task<UpdateUserByIdOutput> UpdateUserByIdAsync(UpdateUserByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeleteUserByIdOutput> DeleteUserByIdAsync(DeleteUserByIdArgs args, CancellationToken cancellationToken = default);
}