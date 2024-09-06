using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class VariationRepository : Repository<Variation>, IVariationRepository
{
    public VariationRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddVariation(Variation variation) => Add(variation);

    public async Task<Variation?> GetVariationByGuidAsync(Guid guid) => await GetAll(variation => variation.Guid == guid).SingleOrDefaultAsync();

    public async Task<Variation?> GetVariationByIdAsync(int id) => await GetAll(variation => variation.Id == id).SingleOrDefaultAsync();

    public async Task<List<Variation>> GetAllVariationsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveVariationByGuid(Guid guid) => Remove(guid);

    public void UpdateVariation(Variation variation) => Update(variation);
}