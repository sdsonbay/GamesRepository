using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _context;

    public OrderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Order>> GetAllOrdersAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Orders.ToListAsync(cancellationToken);
    }

    public async Task<List<Order>> GetOrdersByOrderStatusAsync(int orderStatus, CancellationToken cancellationToken = default)
    {
        return await _context.Orders.Where(o => (int)o.OrderStatus == orderStatus).ToListAsync(cancellationToken);
    }

    public async Task<Order> GetOrderByIdAsync(int orderId, CancellationToken cancellationToken = default)
    {
        return await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderId, cancellationToken);
    }

    public async Task<User> GetUserOfOrderByIdAsync(int orderId, CancellationToken cancellationToken = default)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderId, cancellationToken);
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == order.UserId, cancellationToken);
    }

    public async Task<Game> GetGameOfOrderByIdAsync(int orderId, CancellationToken cancellationToken = default)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderId, cancellationToken);
        return await _context.Games.FirstOrDefaultAsync(g => g.Id == order.GameId, cancellationToken);
    }

    public async Task<bool> CheckOrderExistsByIdAsync(int orderId, CancellationToken cancellationToken = default)
    {
        return await _context.Orders.AnyAsync(o => o.Id == orderId, cancellationToken);
    }

    public async Task<bool> CreateNewOrderAsync(Order order, CancellationToken cancellationToken = default)
    {
        await _context.Orders.AddAsync(order, cancellationToken);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdateOrderByIdAsync(Order order, CancellationToken cancellationToken = default)
    {
        var orderToUpdate = await _context.Orders.FirstOrDefaultAsync(o => o.Id == order.Id,cancellationToken);
        _context.Orders.Update(orderToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteOrderByIdAsync(int orderId, CancellationToken cancellationToken = default)
    {
        var orderToDelete = await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderId,cancellationToken);
        _context.Orders.Remove(orderToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync(cancellationToken);
        return save > 0 ? true : false;
    }
}