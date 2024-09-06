using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IShoppingCartItemRepository : IRepository<ShoppingCartItem>
{
    void AddShoppingCartItem(ShoppingCartItem shoppingcartitem);
    Task<List<ShoppingCartItem>> GetAllShoppingCartItemsAsync();
    Task<ShoppingCartItem?> GetShoppingCartItemByIdAsync(int id);
    Task<ShoppingCartItem?> GetShoppingCartItemByGuidAsync(Guid guid);
    void UpdateShoppingCartItem(ShoppingCartItem shoppingcartitem);
    void RemoveShoppingCartItemByGuid(Guid guid);
}