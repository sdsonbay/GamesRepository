using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetGameOfOrderByIdQueryHandler : IRequestHandler<GetGameOfOrderByIdQuery, GetGameOfOrderByIdOutput>
{
    private readonly IOrderService _orderService;

    public GetGameOfOrderByIdQueryHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<GetGameOfOrderByIdOutput> Handle(GetGameOfOrderByIdQuery request, CancellationToken cancellationToken)
    {
        return await _orderService.GetGameOfOrderByIdAsync(request, cancellationToken);
    }
}