using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class PaymentTypeService : IPaymentTypeService
{
    private readonly IPaymentTypeRepository _repository;

    public PaymentTypeService(IPaymentTypeRepository repository)
    {
        _repository = repository;
    }

    public void AddPaymentType(PaymentType paymenttype) => _repository.AddPaymentType(paymenttype);

    public async Task<PaymentType?> GetPaymentTypeByGuidAsync(Guid guid) => await _repository.GetPaymentTypeByGuidAsync(guid);

    public async Task<PaymentType?> GetPaymentTypeByIdAsync(int id) => await _repository.GetPaymentTypeByIdAsync(id);

    public async Task<List<PaymentType>> GetAllPaymentTypesAsync() => await _repository.GetAllPaymentTypesAsync();

    public void RemovePaymentTypeByGuid(Guid guid) => _repository.RemovePaymentTypeByGuid(guid);

    public void UpdatePaymentType(PaymentType paymenttype) => _repository.UpdatePaymentType(paymenttype);
}
