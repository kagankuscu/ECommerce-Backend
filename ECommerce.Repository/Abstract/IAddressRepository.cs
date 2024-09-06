using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IAddressRepository : IRepository<Address>
{
    void AddAddress(Address address);
    Task<List<Address>> GetAllAddressesAsync();
    Task<Address?> GetAddressByIdAsync(int id);
    Task<Address?> GetAddressByGuidAsync(Guid guid);
    void UpdateAddress(Address address);
    void RemoveAddressByGuid(Guid guid);
}