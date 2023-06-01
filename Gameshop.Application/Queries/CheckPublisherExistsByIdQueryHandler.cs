using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckPublisherExistsByIdQueryHandler : IRequestHandler<CheckPublisherExistsByIdQuery, CheckPublisherExistsByIdOutput>
{
    private readonly IPublisherService _publisherService;

    public CheckPublisherExistsByIdQueryHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<CheckPublisherExistsByIdOutput> Handle(CheckPublisherExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _publisherService.CheckPublisherExistsByIdAsync(request, cancellationToken);
    }
}