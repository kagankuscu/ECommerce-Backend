using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ShippingMethodRepository : Repository<ShippingMethod>, IShippingMethodRepository
{
    public ShippingMethodRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddShippingMethod(ShippingMethod shippingmethod) => Add(shippingmethod);

    public async Task<ShippingMethod?> GetShippingMethodByGuidAsync(Guid guid) => await GetAll(shippingmethod => shippingmethod.Guid == guid).SingleOrDefaultAsync();

    public async Task<ShippingMethod?> GetShippingMethodByIdAsync(int id) => await GetAll(shippingmethod => shippingmethod.Id == id).SingleOrDefaultAsync();

    public async Task<List<ShippingMethod>> GetAllShippingMethodsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveShippingMethodByGuid(Guid guid) => Remove(guid);

    public void UpdateShippingMethod(ShippingMethod shippingmethod) => Update(shippingmethod);
}