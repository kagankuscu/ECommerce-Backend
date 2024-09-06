using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IPromotionService
{
    void AddPromotion(Promotion promotion);
    Task<List<Promotion>> GetAllPromotionsAsync();
    Task<Promotion?> GetPromotionByIdAsync(int id);
    Task<Promotion?> GetPromotionByGuidAsync(Guid guid);
    void UpdatePromotion(Promotion promotion);
    void RemovePromotionByGuid(Guid guid);
}