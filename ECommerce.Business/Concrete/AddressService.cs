using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _repository;

    public AddressService(IAddressRepository repository)
    {
        _repository = repository;
    }

    public void AddAddress(Address address) => _repository.AddAddress(address);

    public async Task<Address?> GetAddressByGuidAsync(Guid guid) => await _repository.GetAddressByGuidAsync(guid);

    public async Task<Address?> GetAddressByIdAsync(int id) => await _repository.GetAddressByIdAsync(id);

    public async Task<List<Address>> GetAllAddressesAsync() => await _repository.GetAllAddressesAsync();

    public void RemoveAddressByGuid(Guid guid) => _repository.RemoveAddressByGuid(guid);

    public void UpdateAddress(Address address) => _repository.UpdateAddress(address);
}
