using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
{
    public ShoppingCartRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddShoppingCart(ShoppingCart shoppingcart) => Add(shoppingcart);

    public async Task<ShoppingCart?> GetShoppingCartByGuidAsync(Guid guid) => await GetAll(shoppingcart => shoppingcart.Guid == guid).SingleOrDefaultAsync();

    public async Task<ShoppingCart?> GetShoppingCartByIdAsync(int id) => await GetAll(shoppingcart => shoppingcart.Id == id).SingleOrDefaultAsync();

    public async Task<List<ShoppingCart>> GetAllShoppingCartsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveShoppingCartByGuid(Guid guid) => Remove(guid);

    public void UpdateShoppingCart(ShoppingCart shoppingcart) => Update(shoppingcart);
}