using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetOrdersByOrderStatusQueryHandler : IRequestHandler<GetOrdersByOrderStatusQuery, GetOrdersByOrderStatusOutput>
{
    private readonly IOrderService _orderService;

    public GetOrdersByOrderStatusQueryHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<GetOrdersByOrderStatusOutput> Handle(GetOrdersByOrderStatusQuery request, CancellationToken cancellationToken)
    {
        return await _orderService.GetOrdersByOrderStatusAsync(request, cancellationToken);
    }
}