using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetPublisherByIdQueryHandler : IRequestHandler<GetPublisherByIdQuery, GetPublisherByIdOutput>
{
    private readonly IPublisherService _publisherService;

    public GetPublisherByIdQueryHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<GetPublisherByIdOutput> Handle(GetPublisherByIdQuery request, CancellationToken cancellationToken)
    {
        return await _publisherService.GetPublisherByIdAsync(request, cancellationToken);
    }
}