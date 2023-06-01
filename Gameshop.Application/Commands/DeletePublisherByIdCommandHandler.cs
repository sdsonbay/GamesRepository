using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeletePublisherByIdCommandHandler : IRequestHandler<DeletePublisherByIdCommand, DeletePublisherByIdOutput>
{
    private readonly IPublisherService _publisherService;

    public DeletePublisherByIdCommandHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<DeletePublisherByIdOutput> Handle(DeletePublisherByIdCommand request, CancellationToken cancellationToken)
    {
        return await _publisherService.DeletePublisherByIdAsync(request, cancellationToken);
    }
}