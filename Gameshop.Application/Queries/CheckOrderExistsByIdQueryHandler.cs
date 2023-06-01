using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckOrderExistsByIdQueryHandler : IRequestHandler<CheckOrderExistsByIdQuery, CheckOrderExistsByIdOutput>
{
    private readonly IOrderService _orderService;

    public CheckOrderExistsByIdQueryHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<CheckOrderExistsByIdOutput> Handle(CheckOrderExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _orderService.CheckOrderExistsByIdAsync(request, cancellationToken);
    }
}