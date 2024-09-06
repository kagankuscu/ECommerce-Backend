using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IProductRepository : IRepository<Product>
{
    void AddProduct(Product product);
    Task<List<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<Product?> GetProductByGuidAsync(Guid guid);
    void UpdateProduct(Product product);
    void RemoveProductByGuid(Guid guid);
}