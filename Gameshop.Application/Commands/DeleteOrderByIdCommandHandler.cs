using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteOrderByIdCommandHandler : IRequestHandler<DeleteOrderByIdCommand, DeleteOrderByIdOutput>
{
    private readonly IOrderService _orderService;

    public DeleteOrderByIdCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<DeleteOrderByIdOutput> Handle(DeleteOrderByIdCommand request, CancellationToken cancellationToken)
    {
        return await _orderService.DeleteOrderByIdAsync(request, cancellationToken);
    }
}