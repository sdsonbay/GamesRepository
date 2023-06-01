using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetPublisherByNameQueryHandler : IRequestHandler<GetPublisherByNameQuery, GetPublisherByNameOutput>
{
    private readonly IPublisherService _publisherService;

    public GetPublisherByNameQueryHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<GetPublisherByNameOutput> Handle(GetPublisherByNameQuery request, CancellationToken cancellationToken)
    {
        return await _publisherService.GetPublisherByNameAsync(request, cancellationToken);
    }
}