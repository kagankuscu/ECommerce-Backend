using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IUserReviewService
{
    void AddUserReview(UserReview userreview);
    Task<List<UserReview>> GetAllUserReviewsAsync();
    Task<UserReview?> GetUserReviewByIdAsync(int id);
    Task<UserReview?> GetUserReviewByGuidAsync(Guid guid);
    void UpdateUserReview(UserReview userreview);
    void RemoveUserReviewByGuid(Guid guid);
}