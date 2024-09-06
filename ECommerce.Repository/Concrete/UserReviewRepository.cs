using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class UserReviewRepository : Repository<UserReview>, IUserReviewRepository
{
    public UserReviewRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddUserReview(UserReview userreview) => Add(userreview);

    public async Task<UserReview?> GetUserReviewByGuidAsync(Guid guid) => await GetAll(userreview => userreview.Guid == guid).SingleOrDefaultAsync();

    public async Task<UserReview?> GetUserReviewByIdAsync(int id) => await GetAll(userreview => userreview.Id == id).SingleOrDefaultAsync();

    public async Task<List<UserReview>> GetAllUserReviewsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveUserReviewByGuid(Guid guid) => Remove(guid);

    public void UpdateUserReview(UserReview userreview) => Update(userreview);
}