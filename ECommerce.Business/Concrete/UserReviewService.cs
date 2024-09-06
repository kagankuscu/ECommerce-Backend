using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class UserReviewService : IUserReviewService
{
    private readonly IUserReviewRepository _repository;

    public UserReviewService(IUserReviewRepository repository)
    {
        _repository = repository;
    }

    public void AddUserReview(UserReview userreview) => _repository.AddUserReview(userreview);

    public async Task<UserReview?> GetUserReviewByGuidAsync(Guid guid) => await _repository.GetUserReviewByGuidAsync(guid);

    public async Task<UserReview?> GetUserReviewByIdAsync(int id) => await _repository.GetUserReviewByIdAsync(id);

    public async Task<List<UserReview>> GetAllUserReviewsAsync() => await _repository.GetAllUserReviewsAsync();

    public void RemoveUserReviewByGuid(Guid guid) => _repository.RemoveUserReviewByGuid(guid);

    public void UpdateUserReview(UserReview userreview) => _repository.UpdateUserReview(userreview);
}
