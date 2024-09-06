using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class ShippingMethodService : IShippingMethodService
{
    private readonly IShippingMethodRepository _repository;

    public ShippingMethodService(IShippingMethodRepository repository)
    {
        _repository = repository;
    }

    public void AddShippingMethod(ShippingMethod shippingmethod) => _repository.AddShippingMethod(shippingmethod);

    public async Task<ShippingMethod?> GetShippingMethodByGuidAsync(Guid guid) => await _repository.GetShippingMethodByGuidAsync(guid);

    public async Task<ShippingMethod?> GetShippingMethodByIdAsync(int id) => await _repository.GetShippingMethodByIdAsync(id);

    public async Task<List<ShippingMethod>> GetAllShippingMethodsAsync() => await _repository.GetAllShippingMethodsAsync();

    public void RemoveShippingMethodByGuid(Guid guid) => _repository.RemoveShippingMethodByGuid(guid);

    public void UpdateShippingMethod(ShippingMethod shippingmethod) => _repository.UpdateShippingMethod(shippingmethod);
}
