using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class PromotionService : IPromotionService
{
    private readonly IPromotionRepository _repository;

    public PromotionService(IPromotionRepository repository)
    {
        _repository = repository;
    }

    public void AddPromotion(Promotion promotion) => _repository.AddPromotion(promotion);

    public async Task<Promotion?> GetPromotionByGuidAsync(Guid guid) => await _repository.GetPromotionByGuidAsync(guid);

    public async Task<Promotion?> GetPromotionByIdAsync(int id) => await _repository.GetPromotionByIdAsync(id);

    public async Task<List<Promotion>> GetAllPromotionsAsync() => await _repository.GetAllPromotionsAsync();

    public void RemovePromotionByGuid(Guid guid) => _repository.RemovePromotionByGuid(guid);

    public void UpdatePromotion(Promotion promotion) => _repository.UpdatePromotion(promotion);
}
