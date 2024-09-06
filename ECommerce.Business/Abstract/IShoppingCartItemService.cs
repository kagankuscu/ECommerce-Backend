using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IShoppingCartItemService
{
    void AddShoppingCartItem(ShoppingCartItem shoppingcartitem);
    Task<List<ShoppingCartItem>> GetAllShoppingCartItemsAsync();
    Task<ShoppingCartItem?> GetShoppingCartItemByIdAsync(int id);
    Task<ShoppingCartItem?> GetShoppingCartItemByGuidAsync(Guid guid);
    void UpdateShoppingCartItem(ShoppingCartItem shoppingcartitem);
    void RemoveShoppingCartItemByGuid(Guid guid);
}