using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ShoppingCartService : IShoppingCartService
{
    private readonly IShoppingCartRepository _repository;

    public ShoppingCartService(IShoppingCartRepository repository)
    {
        _repository = repository;
    }

    public void AddShoppingCart(ShoppingCart shoppingcart) => _repository.AddShoppingCart(shoppingcart);

    public async Task<ShoppingCart?> GetShoppingCartByGuidAsync(Guid guid) => await _repository.GetShoppingCartByGuidAsync(guid);

    public async Task<ShoppingCart?> GetShoppingCartByIdAsync(int id) => await _repository.GetShoppingCartByIdAsync(id);

    public async Task<List<ShoppingCart>> GetAllShoppingCartsAsync() => await _repository.GetAllShoppingCartsAsync();

    public void RemoveShoppingCartByGuid(Guid guid) => _repository.RemoveShoppingCartByGuid(guid);

    public void UpdateShoppingCart(ShoppingCart shoppingcart) => _repository.UpdateShoppingCart(shoppingcart);
}
