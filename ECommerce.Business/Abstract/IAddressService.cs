using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IAddressService
{
    void AddAddress(Address address);
    Task<List<Address>> GetAllAddressesAsync();
    Task<Address?> GetAddressByIdAsync(int id);
    Task<Address?> GetAddressByGuidAsync(Guid guid);
    void UpdateAddress(Address address);
    void RemoveAddressByGuid(Guid guid);
}