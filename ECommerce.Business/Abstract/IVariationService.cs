using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IVariationService
{
    void AddVariation(Variation variation);
    Task<List<Variation>> GetAllVariationsAsync();
    Task<Variation?> GetVariationByIdAsync(int id);
    Task<Variation?> GetVariationByGuidAsync(Guid guid);
    void UpdateVariation(Variation variation);
    void RemoveVariationByGuid(Guid guid);
}