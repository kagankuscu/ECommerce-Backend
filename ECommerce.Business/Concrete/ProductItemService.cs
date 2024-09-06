using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ProductItemService : IProductItemService
{
    private readonly IProductItemRepository _repository;

    public ProductItemService(IProductItemRepository repository)
    {
        _repository = repository;
    }

    public void AddProductItem(ProductItem productitem) => _repository.AddProductItem(productitem);

    public async Task<ProductItem?> GetProductItemByGuidAsync(Guid guid) => await _repository.GetProductItemByGuidAsync(guid);

    public async Task<ProductItem?> GetProductItemByIdAsync(int id) => await _repository.GetProductItemByIdAsync(id);

    public async Task<List<ProductItem>> GetAllProductItemsAsync() => await _repository.GetAllProductItemsAsync();

    public void RemoveProductItemByGuid(Guid guid) => _repository.RemoveProductItemByGuid(guid);

    public void UpdateProductItem(ProductItem productitem) => _repository.UpdateProductItem(productitem);
}
