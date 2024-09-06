using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IVariationOptionRepository : IRepository<VariationOption>
{
    void AddVariationOption(VariationOption variationoption);
    Task<List<VariationOption>> GetAllVariationOptionsAsync();
    Task<VariationOption?> GetVariationOptionByIdAsync(int id);
    Task<VariationOption?> GetVariationOptionByGuidAsync(Guid guid);
    void UpdateVariationOption(VariationOption variationoption);
    void RemoveVariationOptionByGuid(Guid guid);
}