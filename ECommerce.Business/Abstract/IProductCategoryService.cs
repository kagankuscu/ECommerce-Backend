using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IProductCategoryService
{
    void AddProductCategory(ProductCategory productcategory);
    Task<List<ProductCategory>> GetAllProductCategoriesAsync();
    Task<ProductCategory?> GetProductCategoryByIdAsync(int id);
    Task<ProductCategory?> GetProductCategoryByGuidAsync(Guid guid);
    void UpdateProductCategory(ProductCategory productcategory);
    void RemoveProductCategoryByGuid(Guid guid);
}