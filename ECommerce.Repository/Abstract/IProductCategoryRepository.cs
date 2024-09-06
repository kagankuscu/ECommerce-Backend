using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IProductCategoryRepository : IRepository<ProductCategory>
{
    void AddProductCategory(ProductCategory productcategory);
    Task<List<ProductCategory>> GetAllProductCategoriesAsync();
    Task<ProductCategory?> GetProductCategoryByIdAsync(int id);
    Task<ProductCategory?> GetProductCategoryByGuidAsync(Guid guid);
    void UpdateProductCategory(ProductCategory productcategory);
    void RemoveProductCategoryByGuid(Guid guid);
}