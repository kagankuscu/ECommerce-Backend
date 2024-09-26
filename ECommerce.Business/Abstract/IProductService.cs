using ECommerce.Models.Dtos;
using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IProductService
{
    void AddProduct(Product product);
    Task<List<ProductGetDto>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<Product?> GetProductByGuidAsync(Guid guid);
    void UpdateProduct(Product product);
    void RemoveProductByGuid(Guid guid);
}