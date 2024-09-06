using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IUserPaymentMethodService
{
    void AddUserPaymentMethod(UserPaymentMethod userpaymentmethod);
    Task<List<UserPaymentMethod>> GetAllUserPaymentMethodsAsync();
    Task<UserPaymentMethod?> GetUserPaymentMethodByIdAsync(int id);
    Task<UserPaymentMethod?> GetUserPaymentMethodByGuidAsync(Guid guid);
    void UpdateUserPaymentMethod(UserPaymentMethod userpaymentmethod);
    void RemoveUserPaymentMethodByGuid(Guid guid);
}