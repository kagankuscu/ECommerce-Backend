using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ShoppingCartItemService : IShoppingCartItemService
{
    private readonly IShoppingCartItemRepository _repository;

    public ShoppingCartItemService(IShoppingCartItemRepository repository)
    {
        _repository = repository;
    }

    public void AddShoppingCartItem(ShoppingCartItem shoppingcartitem) => _repository.AddShoppingCartItem(shoppingcartitem);

    public async Task<ShoppingCartItem?> GetShoppingCartItemByGuidAsync(Guid guid) => await _repository.GetShoppingCartItemByGuidAsync(guid);

    public async Task<ShoppingCartItem?> GetShoppingCartItemByIdAsync(int id) => await _repository.GetShoppingCartItemByIdAsync(id);

    public async Task<List<ShoppingCartItem>> GetAllShoppingCartItemsAsync() => await _repository.GetAllShoppingCartItemsAsync();

    public void RemoveShoppingCartItemByGuid(Guid guid) => _repository.RemoveShoppingCartItemByGuid(guid);

    public void UpdateShoppingCartItem(ShoppingCartItem shoppingcartitem) => _repository.UpdateShoppingCartItem(shoppingcartitem);
}
