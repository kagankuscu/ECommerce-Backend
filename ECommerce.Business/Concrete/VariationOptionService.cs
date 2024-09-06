using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class VariationOptionService : IVariationOptionService
{
    private readonly IVariationOptionRepository _repository;

    public VariationOptionService(IVariationOptionRepository repository)
    {
        _repository = repository;
    }

    public void AddVariationOption(VariationOption variationoption) => _repository.AddVariationOption(variationoption);

    public async Task<VariationOption?> GetVariationOptionByGuidAsync(Guid guid) => await _repository.GetVariationOptionByGuidAsync(guid);

    public async Task<VariationOption?> GetVariationOptionByIdAsync(int id) => await _repository.GetVariationOptionByIdAsync(id);

    public async Task<List<VariationOption>> GetAllVariationOptionsAsync() => await _repository.GetAllVariationOptionsAsync();

    public void RemoveVariationOptionByGuid(Guid guid) => _repository.RemoveVariationOptionByGuid(guid);

    public void UpdateVariationOption(VariationOption variationoption) => _repository.UpdateVariationOption(variationoption);
}
