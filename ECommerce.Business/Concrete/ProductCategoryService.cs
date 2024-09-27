using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IProductCategoryRepository _repository;

    public ProductCategoryService(IProductCategoryRepository repository)
    {
        _repository = repository;
    }

    public void AddProductCategory(ProductCategory productcategory) => _repository.AddProductCategory(productcategory);

    public async Task<ProductCategory?> GetProductCategoryByGuidAsync(Guid guid) => await _repository.GetProductCategoryByGuidAsync(guid);

    public async Task<ProductCategory?> GetProductCategoryByIdAsync(int id) => await _repository.GetProductCategoryByIdAsync(id);

    public async Task<List<ProductCategory>> GetAllProductCategoriesAsync()
    {
        var categories = await _repository.GetAllProductCategoriesAsync();

        return categories;
    }

    public void RemoveProductCategoryByGuid(Guid guid) => _repository.RemoveProductCategoryByGuid(guid);

    public void UpdateProductCategory(ProductCategory productcategory) => _repository.UpdateProductCategory(productcategory);
}
