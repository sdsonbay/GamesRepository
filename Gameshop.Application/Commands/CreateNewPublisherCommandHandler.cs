using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewPublisherCommandHandler : IRequestHandler<CreateNewPublisherCommand, CreateNewPublisherOutput>
{
    private readonly IPublisherService _publisherService;

    public CreateNewPublisherCommandHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<CreateNewPublisherOutput> Handle(CreateNewPublisherCommand request, CancellationToken cancellationToken)
    {
        return await _publisherService.CreateNewPublisherAsync(request, cancellationToken);
    }
}