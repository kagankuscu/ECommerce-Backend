using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IUserReviewRepository : IRepository<UserReview>
{
    void AddUserReview(UserReview userreview);
    Task<List<UserReview>> GetAllUserReviewsAsync();
    Task<UserReview?> GetUserReviewByIdAsync(int id);
    Task<UserReview?> GetUserReviewByGuidAsync(Guid guid);
    void UpdateUserReview(UserReview userreview);
    void RemoveUserReviewByGuid(Guid guid);
}