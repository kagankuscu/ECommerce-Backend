using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ShopOrderRepository : Repository<ShopOrder>, IShopOrderRepository
{
    public ShopOrderRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddShopOrder(ShopOrder shoporder) => Add(shoporder);

    public async Task<ShopOrder?> GetShopOrderByGuidAsync(Guid guid) => await GetAll(shoporder => shoporder.Guid == guid).SingleOrDefaultAsync();

    public async Task<ShopOrder?> GetShopOrderByIdAsync(int id) => await GetAll(shoporder => shoporder.Id == id).SingleOrDefaultAsync();

    public async Task<List<ShopOrder>> GetAllShopOrdersAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveShopOrderByGuid(Guid guid) => Remove(guid);

    public void UpdateShopOrder(ShopOrder shoporder) => Update(shoporder);
}