using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IPromotionRepository : IRepository<Promotion>
{
    void AddPromotion(Promotion promotion);
    Task<List<Promotion>> GetAllPromotionsAsync();
    Task<Promotion?> GetPromotionByIdAsync(int id);
    Task<Promotion?> GetPromotionByGuidAsync(Guid guid);
    void UpdatePromotion(Promotion promotion);
    void RemovePromotionByGuid(Guid guid);
}