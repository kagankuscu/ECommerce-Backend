using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IProductItemService
{
    void AddProductItem(ProductItem productitem);
    Task<List<ProductItem>> GetAllProductItemsAsync();
    Task<ProductItem?> GetProductItemByIdAsync(int id);
    Task<ProductItem?> GetProductItemByGuidAsync(Guid guid);
    void UpdateProductItem(ProductItem productitem);
    void RemoveProductItemByGuid(Guid guid);
}