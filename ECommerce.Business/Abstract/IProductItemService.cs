using ECommerce.Models.Dtos;
using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IProductItemService
{
    void AddProductItem(ProductItem productitem);
    Task<List<ProductItemGetDto>> GetAllProductItemsAsync();
    Task<ProductItemGetDto?> GetProductItemByIdAsync(int id);
    Task<ProductItem?> GetProductItemByGuidAsync(Guid guid);
    void UpdateProductItem(ProductItem productitem);
    void RemoveProductItemByGuid(Guid guid);
}