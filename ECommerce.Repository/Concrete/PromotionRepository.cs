using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class PromotionRepository : Repository<Promotion>, IPromotionRepository
{
    public PromotionRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddPromotion(Promotion promotion) => Add(promotion);

    public async Task<Promotion?> GetPromotionByGuidAsync(Guid guid) => await GetAll(promotion => promotion.Guid == guid).SingleOrDefaultAsync();

    public async Task<Promotion?> GetPromotionByIdAsync(int id) => await GetAll(promotion => promotion.Id == id).SingleOrDefaultAsync();

    public async Task<List<Promotion>> GetAllPromotionsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemovePromotionByGuid(Guid guid) => Remove(guid);

    public void UpdatePromotion(Promotion promotion) => Update(promotion);
}