using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface IOrderService
{
    Task<GetAllOrdersOutput> GetAllOrdersAsync(CancellationToken cancellationToken = default);
    Task<GetOrdersByOrderStatusOutput> GetOrdersByOrderStatusAsync(GetOrdersByOrderStatusArgs args, CancellationToken cancellationToken = default);
    Task<GetOrderByIdOutput> GetOrderByIdAsync(GetOrderByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetUserOfOrderByIdOutput> GetUserOfOrderByIdAsync(GetUserOfOrderByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetGameOfOrderByIdOutput> GetGameOfOrderByIdAsync(GetGameOfOrderByIdArgs args, CancellationToken cancellationToken = default);

    Task<CheckOrderExistsByIdOutput> CheckOrderExistsByIdAsync(CheckOrderExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewOrderOutput> CreateNewOrderAsync(CreateNewOrderArgs args, CancellationToken cancellationToken = default);
    Task<UpdateOrderByIdOutput> UpdateOrderByIdAsync(UpdateOrderByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeleteOrderByIdOutput> DeleteOrderByIdAsync(DeleteOrderByIdArgs args, CancellationToken cancellationToken = default);
}