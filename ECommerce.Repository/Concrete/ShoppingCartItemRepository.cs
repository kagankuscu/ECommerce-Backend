using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ShoppingCartItemRepository : Repository<ShoppingCartItem>, IShoppingCartItemRepository
{
    public ShoppingCartItemRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddShoppingCartItem(ShoppingCartItem shoppingcartitem) => Add(shoppingcartitem);

    public async Task<ShoppingCartItem?> GetShoppingCartItemByGuidAsync(Guid guid) => await GetAll(shoppingcartitem => shoppingcartitem.Guid == guid).SingleOrDefaultAsync();

    public async Task<ShoppingCartItem?> GetShoppingCartItemByIdAsync(int id) => await GetAll(shoppingcartitem => shoppingcartitem.Id == id).SingleOrDefaultAsync();

    public async Task<List<ShoppingCartItem>> GetAllShoppingCartItemsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveShoppingCartItemByGuid(Guid guid) => Remove(guid);

    public void UpdateShoppingCartItem(ShoppingCartItem shoppingcartitem) => Update(shoppingcartitem);
}