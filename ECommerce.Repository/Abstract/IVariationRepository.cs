using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IVariationRepository : IRepository<Variation>
{
    void AddVariation(Variation variation);
    Task<List<Variation>> GetAllVariationsAsync();
    Task<Variation?> GetVariationByIdAsync(int id);
    Task<Variation?> GetVariationByGuidAsync(Guid guid);
    void UpdateVariation(Variation variation);
    void RemoveVariationByGuid(Guid guid);
}