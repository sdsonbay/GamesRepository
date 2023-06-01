using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task<GetAllOrdersOutput> GetAllOrdersAsync(CancellationToken cancellationToken = default)
    {
        var orders = await _orderRepository.GetAllOrdersAsync(cancellationToken);
        var result = _mapper.Map<List<OrderDto>>(orders);
        var mappedResult = _mapper.Map<List<GetAllOrdersParametersOutput>>(result);
        var output = new GetAllOrdersOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetOrdersByOrderStatusOutput> GetOrdersByOrderStatusAsync(GetOrdersByOrderStatusArgs args, CancellationToken cancellationToken = default)
    {
        var orders = await _orderRepository.GetOrdersByOrderStatusAsync(args.OrderStatus, cancellationToken);
        var result = _mapper.Map<List<OrderDto>>(orders);
        var mappedResult = _mapper.Map<List<GetOrdersByOrderStatusParametersOutput>>(result);
        var output = new GetOrdersByOrderStatusOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetOrderByIdOutput> GetOrderByIdAsync(GetOrderByIdArgs args, CancellationToken cancellationToken = default)
    {
        var order = await _orderRepository.GetOrderByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<OrderDto>(order);
        var output = new GetOrderByIdOutput()
        {
            OrderStatus = result.OrderStatus,
            DateCreated = result.DateCreated,
            UserId = result.UserId,
            GameId = result.GameId,
            User = result.User,
            Game = result.Game
        };
        return output;
    }

    public async Task<GetUserOfOrderByIdOutput> GetUserOfOrderByIdAsync(GetUserOfOrderByIdArgs args, CancellationToken cancellationToken = default)
    {
        var user = await _orderRepository.GetUserOfOrderByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<UserDto>(user);
        var mappedResult = _mapper.Map<GetUserOfOrderByIdOutput>(result);
        var output = new GetUserOfOrderByIdOutput()
        {
            FirstName = mappedResult.FirstName,
            LastName = mappedResult.LastName,
            Username = mappedResult.Username,
            Email = mappedResult.Email
        };
        return output;
    }

    public async Task<GetGameOfOrderByIdOutput> GetGameOfOrderByIdAsync(GetGameOfOrderByIdArgs args, CancellationToken cancellationToken = default)
    {
        var game = await _orderRepository.GetGameOfOrderByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<GameDto>(game);
        var mappedResult = _mapper.Map<GetGameOfOrderByIdOutput>(result);
        var output = new GetGameOfOrderByIdOutput()
        {
            Name = mappedResult.Name,
            Description = mappedResult.Description,
            Price = mappedResult.Price,
            ReleaseDate = mappedResult.ReleaseDate
        };
        return output;
    }

    public async Task<CheckOrderExistsByIdOutput> CheckOrderExistsByIdAsync(CheckOrderExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var orderExists = await _orderRepository.CheckOrderExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckOrderExistsByIdOutput()
        {
            OrderExists = orderExists
        };
        return output;
    }

    public async Task<CreateNewOrderOutput> CreateNewOrderAsync(CreateNewOrderArgs args, CancellationToken cancellationToken = default)
    {
        var orderCreated = await _orderRepository.CreateNewOrderAsync(args.Order, cancellationToken);
        var output = new CreateNewOrderOutput()
        {
            OrderCreated = orderCreated
        };
        return output;
    }

    public async Task<UpdateOrderByIdOutput> UpdateOrderByIdAsync(UpdateOrderByIdArgs args, CancellationToken cancellationToken = default)
    {
        var orderInDb = await _orderRepository.GetOrderByIdAsync(args.Id, cancellationToken);
        orderInDb.GameId = args.GameId;
        orderInDb.UserId = args.UserId;
        orderInDb.DateCreated = args.DateCreated;
        orderInDb.OrderStatus = (int)args.OrderStatus;
        orderInDb.User = await _orderRepository.GetUserOfOrderByIdAsync(orderInDb.Id, cancellationToken);
        orderInDb.Game = await _orderRepository.GetGameOfOrderByIdAsync(orderInDb.Id, cancellationToken);
        var orderUpdated = await _orderRepository.UpdateOrderByIdAsync(orderInDb, cancellationToken);
        var output = new UpdateOrderByIdOutput()
        {
            OrderUpdated = orderUpdated
        };
        return output;
    }

    public async Task<DeleteOrderByIdOutput> DeleteOrderByIdAsync(DeleteOrderByIdArgs args, CancellationToken cancellationToken = default)
    {
        var orderDeleted = await _orderRepository.DeleteOrderByIdAsync(args.Id, cancellationToken);
        var output = new DeleteOrderByIdOutput()
        {
            OrderDeleted = orderDeleted
        };
        return output;
    }
}