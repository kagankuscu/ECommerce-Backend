using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IShippingMethodService
{
    void AddShippingMethod(ShippingMethod shippingmethod);
    Task<List<ShippingMethod>> GetAllShippingMethodsAsync();
    Task<ShippingMethod?> GetShippingMethodByIdAsync(int id);
    Task<ShippingMethod?> GetShippingMethodByGuidAsync(Guid guid);
    void UpdateShippingMethod(ShippingMethod shippingmethod);
    void RemoveShippingMethodByGuid(Guid guid);
}