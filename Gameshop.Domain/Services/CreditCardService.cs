using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class CreditCardService : ICreditCardService
{
    private readonly ICreditCardRepository _creditCardRepository;
    private readonly IMapper _mapper;

    public CreditCardService(ICreditCardRepository creditCardRepository, IMapper mapper)
    {
        _creditCardRepository = creditCardRepository;
        _mapper = mapper;
    }

    public async Task<GetAllCreditCardsOutput> GetAllCreditCardsAsync(CancellationToken cancellationToken = default)
    {
        var creditCards = await _creditCardRepository.GetAllCreditCardsAsync(cancellationToken);
        var result = _mapper.Map<List<CreditCardDto>>(creditCards);
        var mappedResult = _mapper.Map<List<GetAllCreditCardsParametersOutput>>(result);
        var output = new GetAllCreditCardsOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetCreditCardByIdOutput> GetCreditCardByIdAsync(GetCreditCardByIdArgs args, CancellationToken cancellationToken = default)
    {
        var creditCard = await _creditCardRepository.GetCreditCardByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<CreditCardDto>(creditCard);
        var output = new GetCreditCardByIdOutput()
        {
            CardNumber = result.CardNumber,
            Cvv = result.Cvv,
            Balance = result.Balance,
            ExpirationDate = result.ExpirationDate,
            User = result.User
        };
        return output;
    }

    public async Task<GetUserOfCreditCardByIdOutput> GetUserOfCreditCardByIdAsync(GetUserOfCreditCardByIdArgs args, CancellationToken cancellationToken = default)
    {
        var user = await _creditCardRepository.GetUserOfCreditCardByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<UserDto>(user);
        var mappedResult = _mapper.Map<GetUserOfCreditCardByIdOutput>(result);
        var output = new GetUserOfCreditCardByIdOutput()
        {
            FirstName = mappedResult.FirstName,
            LastName = mappedResult.LastName,
            Username = mappedResult.Username,
            Email = mappedResult.Email,
            Password = mappedResult.Password
        };
        return output;
    }

    public async Task<CheckCreditCardExistsByIdOutput> CheckCreditCardExistsByIdAsync(CheckCreditCardExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var creditCardExists = await _creditCardRepository.CheckCreditCardExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckCreditCardExistsByIdOutput()
        {
            CreditCardExists = creditCardExists
        };
        return output;
    }

    public async Task<CreateNewCreditCardOutput> CreateNewCreditCardAsync(CreateNewCreditCardArgs args, CancellationToken cancellationToken = default)
    {
        var creditCardCreated = await _creditCardRepository.CreateNewCreditCardAsync(args.CreditCard, cancellationToken);
        var output = new CreateNewCreditCardOutput()
        {
            CreditCardCreated = creditCardCreated
        };
        return output;
    }

    public async Task<UpdateCreditCardByIdOutput> UpdateCreditCardByIdAsync(UpdateCreditCardByIdArgs args, CancellationToken cancellationToken = default)
    {
        var creditCardInDb = await _creditCardRepository.GetCreditCardByIdAsync(args.Id, cancellationToken);
        creditCardInDb.CardNumber = args.CardNumber;
        creditCardInDb.Cvv = args.Cvv;
        creditCardInDb.Balance = args.Balance;
        creditCardInDb.ExpirationDate = args.ExpirationDate;
        creditCardInDb.UserId = args.UserId;
        var creditCardUpdated = await _creditCardRepository.UpdateCreditCardByIdAsync(creditCardInDb, cancellationToken);
        var output = new UpdateCreditCardByIdOutput()
        {
            CreditCardUpdated = creditCardUpdated
        };
        return output;
    }

    public async Task<DeleteCreditCardByIdOutput> DeleteCreditCardByIdAsync(DeleteCreditCardByIdArgs args, CancellationToken cancellationToken = default)
    {
        var creditCardDeleted = await _creditCardRepository.DeleteCreditCardByIdAsync(args.Id, cancellationToken);
        var output = new DeleteCreditCardByIdOutput()
        {
            CreditCardDeleted = creditCardDeleted
        };
        return output;
    }
}