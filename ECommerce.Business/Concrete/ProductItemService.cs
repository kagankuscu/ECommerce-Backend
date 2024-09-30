using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Models.Dtos;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Business.Concrete;

public class ProductItemService : IProductItemService
{
    private readonly IProductItemRepository _repository;
    private readonly IMapper _mapper;

    public ProductItemService(IProductItemRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public void AddProductItem(ProductItem productitem) => _repository.AddProductItem(productitem);

    public async Task<ProductItem?> GetProductItemByGuidAsync(Guid guid) => await _repository.GetProductItemByGuidAsync(guid);

    public async Task<ProductItemGetDto?> GetProductItemByIdAsync(int id)
    {
        var productItem = await GetAllProductItemsAsync();
        return productItem.Where(p => p.Id == id).SingleOrDefault();
    }

    public async Task<List<ProductItemGetDto>> GetAllProductItemsAsync()
    {
        var productItems = await _repository.GetAll()
            .Include(pi => pi.Product)
            .ThenInclude(pi => pi!.ProductCategory)
            .ToListAsync();

        return _mapper.Map<List<ProductItemGetDto>>(productItems);
    }

    public void RemoveProductItemByGuid(Guid guid) => _repository.RemoveProductItemByGuid(guid);

    public void UpdateProductItem(ProductItem productitem) => _repository.UpdateProductItem(productitem);
}
