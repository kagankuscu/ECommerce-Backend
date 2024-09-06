using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IPaymentTypeRepository : IRepository<PaymentType>
{
    void AddPaymentType(PaymentType paymenttype);
    Task<List<PaymentType>> GetAllPaymentTypesAsync();
    Task<PaymentType?> GetPaymentTypeByIdAsync(int id);
    Task<PaymentType?> GetPaymentTypeByGuidAsync(Guid guid);
    void UpdatePaymentType(PaymentType paymenttype);
    void RemovePaymentTypeByGuid(Guid guid);
}