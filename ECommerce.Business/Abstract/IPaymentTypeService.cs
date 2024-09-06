using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IPaymentTypeService
{
    void AddPaymentType(PaymentType paymenttype);
    Task<List<PaymentType>> GetAllPaymentTypesAsync();
    Task<PaymentType?> GetPaymentTypeByIdAsync(int id);
    Task<PaymentType?> GetPaymentTypeByGuidAsync(Guid guid);
    void UpdatePaymentType(PaymentType paymenttype);
    void RemovePaymentTypeByGuid(Guid guid);
}