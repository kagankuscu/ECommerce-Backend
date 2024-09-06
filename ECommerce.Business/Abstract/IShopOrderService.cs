using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IShopOrderService
{
    void AddShopOrder(ShopOrder shoporder);
    Task<List<ShopOrder>> GetAllShopOrdersAsync();
    Task<ShopOrder?> GetShopOrderByIdAsync(int id);
    Task<ShopOrder?> GetShopOrderByGuidAsync(Guid guid);
    void UpdateShopOrder(ShopOrder shoporder);
    void RemoveShopOrderByGuid(Guid guid);
}