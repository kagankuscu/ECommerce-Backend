using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddProductCategory(ProductCategory productcategory) => Add(productcategory);

    public async Task<ProductCategory?> GetProductCategoryByGuidAsync(Guid guid) => await GetAll(productcategory => productcategory.Guid == guid).SingleOrDefaultAsync();

    public async Task<ProductCategory?> GetProductCategoryByIdAsync(int id) => await GetAll(productcategory => productcategory.Id == id).SingleOrDefaultAsync();

    public async Task<List<ProductCategory>> GetAllProductCategoriesAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveProductCategoryByGuid(Guid guid) => Remove(guid);

    public void UpdateProductCategory(ProductCategory productcategory) => Update(productcategory);
}