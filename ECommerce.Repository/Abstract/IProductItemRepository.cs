using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IProductItemRepository : IRepository<ProductItem>
{
    void AddProductItem(ProductItem productitem);
    Task<List<ProductItem>> GetAllProductItemsAsync();
    Task<ProductItem?> GetProductItemByIdAsync(int id);
    Task<ProductItem?> GetProductItemByGuidAsync(Guid guid);
    void UpdateProductItem(ProductItem productitem);
    void RemoveProductItemByGuid(Guid guid);
}