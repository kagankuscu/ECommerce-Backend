using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class VariationOptionRepository : Repository<VariationOption>, IVariationOptionRepository
{
    public VariationOptionRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddVariationOption(VariationOption variationoption) => Add(variationoption);

    public async Task<VariationOption?> GetVariationOptionByGuidAsync(Guid guid) => await GetAll(variationoption => variationoption.Guid == guid).SingleOrDefaultAsync();

    public async Task<VariationOption?> GetVariationOptionByIdAsync(int id) => await GetAll(variationoption => variationoption.Id == id).SingleOrDefaultAsync();

    public async Task<List<VariationOption>> GetAllVariationOptionsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveVariationOptionByGuid(Guid guid) => Remove(guid);

    public void UpdateVariationOption(VariationOption variationoption) => Update(variationoption);
}