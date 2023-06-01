using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateOrderByIdCommandHandler : IRequestHandler<UpdateOrderByIdCommand, UpdateOrderByIdOutput>
{
    private readonly IOrderService _orderService;

    public UpdateOrderByIdCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<UpdateOrderByIdOutput> Handle(UpdateOrderByIdCommand request, CancellationToken cancellationToken)
    {
        return await _orderService.UpdateOrderByIdAsync(request, cancellationToken);
    }
}