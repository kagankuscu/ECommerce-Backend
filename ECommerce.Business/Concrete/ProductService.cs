using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Models.Dtos;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Business.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public void AddProduct(Product product) => _repository.AddProduct(product);

    public async Task<Product?> GetProductByGuidAsync(Guid guid) => await _repository.GetProductByGuidAsync(guid);

    public async Task<ProductGetDto?> GetProductByIdAsync(int id)
    {
        var product = await GetAllProductsAsync();
        return product.Where(p => p.Id == id).SingleOrDefault();
    }

    public async Task<List<ProductGetDto>> GetAllProductsAsync()
    {
        List<Product> products = await _repository.GetAll()
            .Include(p => p.ProductCategory)
            .Include(p => p.ProductItems)
            .ToListAsync();
        return _mapper.Map<List<ProductGetDto>>(products);
    }

    public void RemoveProductByGuid(Guid guid) => _repository.RemoveProductByGuid(guid);

    public void UpdateProduct(Product product) => _repository.UpdateProduct(product);
}
