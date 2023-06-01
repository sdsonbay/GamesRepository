using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAllPublishersQueryHandler : IRequestHandler<GetAllPublishersQuery, GetAllPublishersOutput>
{
    private readonly IPublisherService _publisherService;

    public GetAllPublishersQueryHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<GetAllPublishersOutput> Handle(GetAllPublishersQuery request, CancellationToken cancellationToken)
    {
        return await _publisherService.GetAllPublishersAsync(cancellationToken);
    }
}