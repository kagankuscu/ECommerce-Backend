using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class VariationService : IVariationService
{
    private readonly IVariationRepository _repository;

    public VariationService(IVariationRepository repository)
    {
        _repository = repository;
    }

    public void AddVariation(Variation variation) => _repository.AddVariation(variation);

    public async Task<Variation?> GetVariationByGuidAsync(Guid guid) => await _repository.GetVariationByGuidAsync(guid);

    public async Task<Variation?> GetVariationByIdAsync(int id) => await _repository.GetVariationByIdAsync(id);

    public async Task<List<Variation>> GetAllVariationsAsync() => await _repository.GetAllVariationsAsync();

    public void RemoveVariationByGuid(Guid guid) => _repository.RemoveVariationByGuid(guid);

    public void UpdateVariation(Variation variation) => _repository.UpdateVariation(variation);
}
