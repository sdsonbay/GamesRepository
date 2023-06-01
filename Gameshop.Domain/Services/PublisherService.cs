using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class PublisherService : IPublisherService
{
    private readonly IPublisherRepository _publisherRepository;
    private readonly IMapper _mapper;

    public PublisherService(IPublisherRepository publisherRepository, IMapper mapper)
    {
        _publisherRepository = publisherRepository;
        _mapper = mapper;
    }

    public async Task<GetAllPublishersOutput> GetAllPublishersAsync(CancellationToken cancellationToken = default)
    {
        var publishers = await _publisherRepository.GetAllPublishersAsync(cancellationToken);
        var result = _mapper.Map<List<PublisherDto>>(publishers);
        var mappedResult = _mapper.Map<List<GetAllPublishersParametersOutput>>(result);
        var output = new GetAllPublishersOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetPublisherByIdOutput> GetPublisherByIdAsync(GetPublisherByIdArgs args, CancellationToken cancellationToken = default)
    {
        var publisher = await _publisherRepository.GetPublisherByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<PublisherDto>(publisher);
        var output = new GetPublisherByIdOutput()
        {
            Name = result.Name,
            Games = result.Games
        };
        return output;
    }

    public async Task<GetPublisherByNameOutput> GetPublisherByNameAsync(GetPublisherByNameArgs args, CancellationToken cancellationToken = default)
    {
        var publisher = await _publisherRepository.GetPublisherByNameAsync(args.Name, cancellationToken);
        var result = _mapper.Map<PublisherDto>(publisher);
        var output = new GetPublisherByNameOutput()
        {
            Name = result.Name,
            Games = result.Games
        };
        return output;
    }

    public async Task<GetGamesOfPublisherByIdOutput> GetGamesOfPublisherByIdAsync(GetGamesOfPublisherByIdArgs args, CancellationToken cancellationToken = default)
    {
        var games = await _publisherRepository.GetGamesOfPublisherByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<List<GameDto>>(games);
        var mappedResult = _mapper.Map<List<GetGamesOfPublisherByIdParametersOutput>>(result);
        var output = new GetGamesOfPublisherByIdOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<CheckPublisherExistsByIdOutput> CheckPublisherExistsByIdAsync(CheckPublisherExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var publisherExists = await _publisherRepository.CheckPublisherExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckPublisherExistsByIdOutput()
        {
            PublisherExists = publisherExists
        };
        return output;
    }

    public async Task<CreateNewPublisherOutput> CreateNewPublisherAsync(CreateNewPublisherArgs args, CancellationToken cancellationToken = default)
    {
        var publisherCreated = await _publisherRepository.CreateNewPublisherAsync(args.Publisher, cancellationToken);
        var output = new CreateNewPublisherOutput()
        {
            PublisherCreated = publisherCreated
        };
        return output;
    }

    public async Task<UpdatePublisherByIdOutput> UpdatePublisherByIdAsync(UpdatePublisherByIdArgs args, CancellationToken cancellationToken = default)
    {
        var publisherInDb = await _publisherRepository.GetPublisherByIdAsync(args.Id, cancellationToken);
        publisherInDb.Name = args.Name;
        var publisherUpdated = await _publisherRepository.UpdatePublisherByIdAsync(publisherInDb, cancellationToken);
        var output = new UpdatePublisherByIdOutput()
        {
            PublisherUpdated = publisherUpdated
        };
        return output;
    }

    public async Task<DeletePublisherByIdOutput> DeletePublisherByIdAsync(DeletePublisherByIdArgs args, CancellationToken cancellationToken = default)
    {
        var publisherDeleted = await _publisherRepository.DeletePublisherByIdAsync(args.Id, cancellationToken);
        var output = new DeletePublisherByIdOutput()
        {
            PublisherDeleted = publisherDeleted
        };
        return output;
    }
}