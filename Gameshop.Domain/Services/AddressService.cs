using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;

    public AddressService(IAddressRepository addressRepository, IMapper mapper)
    {
        _addressRepository = addressRepository;
        _mapper = mapper;
    }

    public async Task<GetAllAddressesOutput> GetAllAddressesAsync(CancellationToken cancellationToken = default)
    {
        var addresses = await _addressRepository.GetAllAddressesAsync(cancellationToken);
        var result = _mapper.Map<List<AddressDto>>(addresses);
        var mappedResult = _mapper.Map<List<GetAllAddressesParametersOutput>>(result);
        var output = new GetAllAddressesOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetAddressesByCountryOutput> GetAddressesByCountryAsync(GetAddressesByCountryArgs args, CancellationToken cancellationToken = default)
    {
        var addresses = await _addressRepository.GetAddressesByCountryAsync(args.Country, cancellationToken);
        var result = _mapper.Map<List<AddressDto>>(addresses);
        var mappedResult = _mapper.Map<List<GetAddressesByCountryParametersOutput>>(result);
        var output = new GetAddressesByCountryOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetAddressesByCityOutput> GetAddressesByCityAsync(GetAddressesByCityArgs args, CancellationToken cancellationToken = default)
    {
        var addresses = await _addressRepository.GetAddressesByCityAsync(args.City, cancellationToken);
        var result = _mapper.Map<List<AddressDto>>(addresses);
        var mappedResult = _mapper.Map<List<GetAddressesByCityParametersOutput>>(result);
        var output = new GetAddressesByCityOutput()
        {
            Parameters = mappedResult
        };
        return output;
    }

    public async Task<GetAddressByIdOutput> GetAddressByIdAsync(GetAddressByIdArgs args, CancellationToken cancellationToken = default)
    {
        var address = await _addressRepository.GetAddressByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<AddressDto>(address);
        var output = new GetAddressByIdOutput()
        {
            Country = result.Country,
            City = result.City,
            Town = result.Town,
            District = result.District,
            Street = result.Street,
            AddressDetail = result.AddressDetail,
            PostalCode = result.PostalCode,
            AddressType = (int)result.AddressType,
            User = result.User
        };
        return output;
    }

    public async Task<GetUserOfAddressByIdOutput> GetUserOfAddressByIdAsync(GetUserOfAddressByIdArgs args, CancellationToken cancellationToken = default)
    {
        var user = await _addressRepository.GetUserOfAddressByIdAsync(args.Id, cancellationToken);
        var result = _mapper.Map<UserDto>(user);
        var mappedResult = _mapper.Map<GetUserOfAddressByIdOutput>(result);
        var output = new GetUserOfAddressByIdOutput()
        {
            FirstName = mappedResult.FirstName,
            LastName = mappedResult.LastName,
            Username = mappedResult.Username,
            Email = mappedResult.Email
        };
        return output;
    }

    public async Task<CheckAddressExistsByIdOutput> CheckAddressExistsByIdAsync(CheckAddressExistsByIdArgs args, CancellationToken cancellationToken = default)
    {
        var addressExists = await _addressRepository.CheckAddressExistsByIdAsync(args.Id, cancellationToken);
        var output = new CheckAddressExistsByIdOutput()
        {
            AddressExists = addressExists
        };
        return output;
    }

    public async Task<CreateNewAddressOutput> CreateNewAddressAsync(CreateNewAddressArgs args, CancellationToken cancellationToken = default)
    {
        var addressCreated = await _addressRepository.CreateNewAddressAsync(args.Address, cancellationToken);
        var output = new CreateNewAddressOutput()
        {
            AddressCreated = addressCreated
        };
        return output;
    }

    public async Task<UpdateAddressByIdOutput> UpdateAddressByIdAsync(UpdateAddressByIdArgs args, CancellationToken cancellationToken = default)
    {
        var addressInDb = await _addressRepository.GetAddressByIdAsync(args.Id, cancellationToken);
        addressInDb.Country = args.Country;
        addressInDb.City = args.City;
        addressInDb.Town = args.Town;
        addressInDb.District = args.District;
        addressInDb.Street = args.Street;
        addressInDb.PostalCode = args.PostalCode;
        addressInDb.AddressDetail = args.AddressDetail;
        addressInDb.AddressType = args.AddressType;
        addressInDb.UserId = args.UserId;
        var addressUpdated = await _addressRepository.UpdateAddressByIdAsync(addressInDb, cancellationToken);
        var output = new UpdateAddressByIdOutput()
        {
            AddressUpdated = addressUpdated
        };
        return output;
    }

    public async Task<DeleteAddressByIdOutput> DeleteAddressByIdAsync(DeleteAddressByIdArgs args, CancellationToken cancellationToken = default)
    {
        var addressDeleted = await _addressRepository.DeleteAddressByIdAsync(args.Id, cancellationToken);
        var output = new DeleteAddressByIdOutput()
        {
            AddressDeleted = addressDeleted
        };
        return output;
    }
}