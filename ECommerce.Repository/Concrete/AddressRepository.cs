using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class AddressRepository : Repository<Address>, IAddressRepository
{
    public AddressRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddAddress(Address address) => Add(address);

    public async Task<Address?> GetAddressByGuidAsync(Guid guid) => await GetAll(address => address.Guid == guid).SingleOrDefaultAsync();

    public async Task<Address?> GetAddressByIdAsync(int id) => await GetAll(address => address.Id == id).SingleOrDefaultAsync();

    public async Task<List<Address>> GetAllAddressesAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveAddressByGuid(Guid guid) => Remove(guid);

    public void UpdateAddress(Address address) => Update(address);
}