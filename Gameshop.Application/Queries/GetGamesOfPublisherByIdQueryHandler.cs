using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetGamesOfPublisherByIdQueryHandler : IRequestHandler<GetGamesOfPublisherByIdQuery, GetGamesOfPublisherByIdOutput>
{
    private readonly IPublisherService _publisherService;

    public GetGamesOfPublisherByIdQueryHandler(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    public async Task<GetGamesOfPublisherByIdOutput> Handle(GetGamesOfPublisherByIdQuery request, CancellationToken cancellationToken)
    {
        return await _publisherService.GetGamesOfPublisherByIdAsync(request, cancellationToken);
    }
}