using ECommerce.Models.Dtos;
using ECommerce.Models.Models;
using ECommerce.Models.RequestParameters;

namespace ECommerce.Business.Abstract;

public interface IProductItemService
{
    void AddProductItem(ProductItem productitem);
    Task<PagedList<ProductItemGetDto>> GetAllProductItemsAsync(ProductItemParameters productItemParameters);
    Task<ProductItemGetDto?> GetProductItemByIdAsync(int id);
    Task<List<ProductItemGetDto>> GetRelatedProductItemAsync(ProductItemRelatedParameters productItemRelatedParameters);
    Task<ProductItem?> GetProductItemByGuidAsync(Guid guid);
    void UpdateProductItem(ProductItem productitem);
    void RemoveProductItemByGuid(Guid guid);
}