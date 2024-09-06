using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IUserPaymentMethodRepository : IRepository<UserPaymentMethod>
{
    void AddUserPaymentMethod(UserPaymentMethod userpaymentmethod);
    Task<List<UserPaymentMethod>> GetAllUserPaymentMethodsAsync();
    Task<UserPaymentMethod?> GetUserPaymentMethodByIdAsync(int id);
    Task<UserPaymentMethod?> GetUserPaymentMethodByGuidAsync(Guid guid);
    void UpdateUserPaymentMethod(UserPaymentMethod userpaymentmethod);
    void RemoveUserPaymentMethodByGuid(Guid guid);
}