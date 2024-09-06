using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IVariationOptionService
{
    void AddVariationOption(VariationOption variationoption);
    Task<List<VariationOption>> GetAllVariationOptionsAsync();
    Task<VariationOption?> GetVariationOptionByIdAsync(int id);
    Task<VariationOption?> GetVariationOptionByGuidAsync(Guid guid);
    void UpdateVariationOption(VariationOption variationoption);
    void RemoveVariationOptionByGuid(Guid guid);
}