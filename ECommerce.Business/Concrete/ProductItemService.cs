using System.Net.NetworkInformation;
using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Models.Dtos;
using ECommerce.Models.Models;
using ECommerce.Models.RequestParameters;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Extension;
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
        var productItem = await _repository
            .GetAll(p => p.Id == id)
            .Include(p => p.Product)
            .ThenInclude(p => p!.ProductCategory)
            .SingleOrDefaultAsync();

        return _mapper.Map<ProductItemGetDto>(productItem);
    }

    public async Task<PagedList<ProductItemGetDto>> GetAllProductItemsAsync(ProductItemParameters productItemParameters)
    {
        var productItems = await _repository.GetAll()
            .Include(pi => pi.Product)
            .ThenInclude(pi => pi!.ProductCategory)
            .FilterProductItemsByCategoryName(productItemParameters.CategoryName!)
            .ToListAsync();

        return PagedList<ProductItemGetDto>.ToPagedList(_mapper.Map<List<ProductItemGetDto>>(productItems), productItemParameters.PageNumber, productItemParameters.PublicSize);
    }

    public void RemoveProductItemByGuid(Guid guid) => _repository.RemoveProductItemByGuid(guid);

    public void UpdateProductItem(ProductItem productitem) => _repository.UpdateProductItem(productitem);

    public async Task<List<ProductItemGetDto>> GetRelatedProductItemAsync(ProductItemRelatedParameters productItemRelatedParameters)
    {
        var productItems = await _repository.GetAll()
            .Include(pi => pi.Product)
            .ThenInclude(pi => pi!.ProductCategory)
            .FilterProductItemsByCategoryName(productItemRelatedParameters.CategoryName!)
            .FilterProductItemsBetweenByPrice(
                Convert.ToInt32(productItemRelatedParameters.Price) - productItemRelatedParameters.MinPrice,
                Convert.ToInt32(productItemRelatedParameters.Price) + productItemRelatedParameters.MaxPrice)
            .Take(8)
            .OrderBy(pi => Guid.NewGuid())
            .ToListAsync();

        return _mapper.Map<List<ProductItemGetDto>>(productItems);
    }
}
