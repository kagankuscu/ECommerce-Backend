using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ProductItemRepository : Repository<ProductItem>, IProductItemRepository
{
    public ProductItemRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddProductItem(ProductItem productitem) => Add(productitem);

    public async Task<ProductItem?> GetProductItemByGuidAsync(Guid guid) => await GetAll(productitem => productitem.Guid == guid).SingleOrDefaultAsync();

    public async Task<ProductItem?> GetProductItemByIdAsync(int id) => await GetAll(productitem => productitem.Id == id).SingleOrDefaultAsync();

    public async Task<List<ProductItem>> GetAllProductItemsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveProductItemByGuid(Guid guid) => Remove(guid);

    public void UpdateProductItem(ProductItem productitem) => Update(productitem);
}