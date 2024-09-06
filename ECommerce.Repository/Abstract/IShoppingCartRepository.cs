using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IShoppingCartRepository : IRepository<ShoppingCart>
{
    void AddShoppingCart(ShoppingCart shoppingcart);
    Task<List<ShoppingCart>> GetAllShoppingCartsAsync();
    Task<ShoppingCart?> GetShoppingCartByIdAsync(int id);
    Task<ShoppingCart?> GetShoppingCartByGuidAsync(Guid guid);
    void UpdateShoppingCart(ShoppingCart shoppingcart);
    void RemoveShoppingCartByGuid(Guid guid);
}