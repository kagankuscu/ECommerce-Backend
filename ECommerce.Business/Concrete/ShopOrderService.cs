using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ShopOrderService : IShopOrderService
{
    private readonly IShopOrderRepository _repository;

    public ShopOrderService(IShopOrderRepository repository)
    {
        _repository = repository;
    }

    public void AddShopOrder(ShopOrder shoporder) => _repository.AddShopOrder(shoporder);

    public async Task<ShopOrder?> GetShopOrderByGuidAsync(Guid guid) => await _repository.GetShopOrderByGuidAsync(guid);

    public async Task<ShopOrder?> GetShopOrderByIdAsync(int id) => await _repository.GetShopOrderByIdAsync(id);

    public async Task<List<ShopOrder>> GetAllShopOrdersAsync() => await _repository.GetAllShopOrdersAsync();

    public void RemoveShopOrderByGuid(Guid guid) => _repository.RemoveShopOrderByGuid(guid);

    public void UpdateShopOrder(ShopOrder shoporder) => _repository.UpdateShopOrder(shoporder);
}
