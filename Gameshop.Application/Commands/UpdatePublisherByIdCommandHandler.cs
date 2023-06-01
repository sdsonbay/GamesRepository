using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdatePublisherByIdCommandHandler : IRequestHandler<UpdatePublisherByIdCommand, UpdatePublisherByIdOutput>
{
    private readonly IPublisherService _publisherService;

    public UpdatePublisherByIdCommandHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<UpdatePublisherByIdOutput> Handle(UpdatePublisherByIdCommand request, CancellationToken cancellationToken)
    {
        return await _publisherService.UpdatePublisherByIdAsync(request, cancellationToken);
    }
}