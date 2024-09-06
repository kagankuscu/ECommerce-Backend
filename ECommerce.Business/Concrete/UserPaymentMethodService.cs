using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class UserPaymentMethodService : IUserPaymentMethodService
{
    private readonly IUserPaymentMethodRepository _repository;

    public UserPaymentMethodService(IUserPaymentMethodRepository repository)
    {
        _repository = repository;
    }

    public void AddUserPaymentMethod(UserPaymentMethod userpaymentmethod) => _repository.AddUserPaymentMethod(userpaymentmethod);

    public async Task<UserPaymentMethod?> GetUserPaymentMethodByGuidAsync(Guid guid) => await _repository.GetUserPaymentMethodByGuidAsync(guid);

    public async Task<UserPaymentMethod?> GetUserPaymentMethodByIdAsync(int id) => await _repository.GetUserPaymentMethodByIdAsync(id);

    public async Task<List<UserPaymentMethod>> GetAllUserPaymentMethodsAsync() => await _repository.GetAllUserPaymentMethodsAsync();

    public void RemoveUserPaymentMethodByGuid(Guid guid) => _repository.RemoveUserPaymentMethodByGuid(guid);

    public void UpdateUserPaymentMethod(UserPaymentMethod userpaymentmethod) => _repository.UpdateUserPaymentMethod(userpaymentmethod);
}
