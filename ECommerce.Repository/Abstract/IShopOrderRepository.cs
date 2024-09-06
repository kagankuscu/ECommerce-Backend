using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IShopOrderRepository : IRepository<ShopOrder>
{
    void AddShopOrder(ShopOrder shoporder);
    Task<List<ShopOrder>> GetAllShopOrdersAsync();
    Task<ShopOrder?> GetShopOrderByIdAsync(int id);
    Task<ShopOrder?> GetShopOrderByGuidAsync(Guid guid);
    void UpdateShopOrder(ShopOrder shoporder);
    void RemoveShopOrderByGuid(Guid guid);
}