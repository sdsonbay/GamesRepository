using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserOfOrderByIdQueryHandler : IRequestHandler<GetUserOfOrderByIdQuery, GetUserOfOrderByIdOutput>
{
    private readonly IOrderService _orderService;

    public GetUserOfOrderByIdQueryHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<GetUserOfOrderByIdOutput> Handle(GetUserOfOrderByIdQuery request, CancellationToken cancellationToken)
    {
        return await _orderService.GetUserOfOrderByIdAsync(request, cancellationToken);
    }
}