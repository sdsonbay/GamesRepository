using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewOrderCommandHandler : IRequestHandler<CreateNewOrderCommand, CreateNewOrderOutput>
{
    private readonly IOrderService _orderService;

    public CreateNewOrderCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<CreateNewOrderOutput> Handle(CreateNewOrderCommand request, CancellationToken cancellationToken)
    {
        return await _orderService.CreateNewOrderAsync(request, cancellationToken);
    }
}