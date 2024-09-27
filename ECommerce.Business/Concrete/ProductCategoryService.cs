using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Models.Dtos;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IProductCategoryRepository _repository;
    private readonly IMapper _mapper;

    public ProductCategoryService(IProductCategoryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public void AddProductCategory(ProductCategory productcategory) => _repository.AddProductCategory(productcategory);

    public async Task<CategoryGetDto?> GetProductCategoryByGuidAsync(Guid guid) => _mapper.Map<CategoryGetDto>(await _repository.GetProductCategoryByGuidAsync(guid));

    public async Task<CategoryGetDto?> GetProductCategoryByIdAsync(int id) => _mapper.Map<CategoryGetDto>(await _repository.GetProductCategoryByIdAsync(id));

    public async Task<List<CategoryGetDto>> GetAllProductCategoriesAsync()
    {
        var categories = await _repository.GetAllProductCategoriesAsync();

        return _mapper.Map<List<CategoryGetDto>>(categories);
    }

    public void RemoveProductCategoryByGuid(Guid guid) => _repository.RemoveProductCategoryByGuid(guid);

    public void UpdateProductCategory(ProductCategory productcategory) => _repository.UpdateProductCategory(productcategory);
}
