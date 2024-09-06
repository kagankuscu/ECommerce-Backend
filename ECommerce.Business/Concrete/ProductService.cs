using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public void AddProduct(Product product) => _repository.AddProduct(product);

    public async Task<Product?> GetProductByGuidAsync(Guid guid) => await _repository.GetProductByGuidAsync(guid);

    public async Task<Product?> GetProductByIdAsync(int id) => await _repository.GetProductByIdAsync(id);

    public async Task<List<Product>> GetAllProductsAsync() => await _repository.GetAllProductsAsync();

    public void RemoveProductByGuid(Guid guid) => _repository.RemoveProductByGuid(guid);

    public void UpdateProduct(Product product) => _repository.UpdateProduct(product);
}
