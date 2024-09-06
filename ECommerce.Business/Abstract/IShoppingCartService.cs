using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IShoppingCartService
{
    void AddShoppingCart(ShoppingCart shoppingcart);
    Task<List<ShoppingCart>> GetAllShoppingCartsAsync();
    Task<ShoppingCart?> GetShoppingCartByIdAsync(int id);
    Task<ShoppingCart?> GetShoppingCartByGuidAsync(Guid guid);
    void UpdateShoppingCart(ShoppingCart shoppingcart);
    void RemoveShoppingCartByGuid(Guid guid);
}