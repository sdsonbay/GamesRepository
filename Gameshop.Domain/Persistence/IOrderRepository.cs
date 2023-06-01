using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface IOrderRepository
{
    Task<List<Order>> GetAllOrdersAsync(CancellationToken cancellationToken = default);
    Task<List<Order>> GetOrdersByOrderStatusAsync(int orderStatus, CancellationToken cancellationToken = default);
    Task<Order> GetOrderByIdAsync(int orderId, CancellationToken cancellationToken = default);
    Task<User> GetUserOfOrderByIdAsync(int orderId, CancellationToken cancellationToken = default);
    Task<Game> GetGameOfOrderByIdAsync(int orderId, CancellationToken cancellationToken = default);

    Task<bool> CheckOrderExistsByIdAsync(int orderId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewOrderAsync(Order order, CancellationToken cancellationToken = default);
    Task<bool> UpdateOrderByIdAsync(Order order, CancellationToken cancellationToken = default);
    Task<bool> DeleteOrderByIdAsync(int orderId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}