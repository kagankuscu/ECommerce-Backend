using ECommerce.Models.Dtos;
using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IProductCategoryService
{
    void AddProductCategory(ProductCategory productcategory);
    Task<List<CategoryGetDto>> GetAllProductCategoriesAsync();
    Task<CategoryGetDto?> GetProductCategoryByIdAsync(int id);
    Task<CategoryGetDto?> GetProductCategoryByGuidAsync(Guid guid);
    void UpdateProductCategory(ProductCategory productcategory);
    void RemoveProductCategoryByGuid(Guid guid);
}