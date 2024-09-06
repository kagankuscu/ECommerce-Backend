using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddProduct(Product product) => Add(product);

    public async Task<Product?> GetProductByGuidAsync(Guid guid) => await GetAll(product => product.Guid == guid).SingleOrDefaultAsync();

    public async Task<Product?> GetProductByIdAsync(int id) => await GetAll(product => product.Id == id).SingleOrDefaultAsync();

    public async Task<List<Product>> GetAllProductsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveProductByGuid(Guid guid) => Remove(guid);

    public void UpdateProduct(Product product) => Update(product);
}