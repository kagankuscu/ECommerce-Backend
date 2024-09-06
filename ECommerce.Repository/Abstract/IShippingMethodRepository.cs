using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IShippingMethodRepository : IRepository<ShippingMethod>
{
    void AddShippingMethod(ShippingMethod shippingmethod);
    Task<List<ShippingMethod>> GetAllShippingMethodsAsync();
    Task<ShippingMethod?> GetShippingMethodByIdAsync(int id);
    Task<ShippingMethod?> GetShippingMethodByGuidAsync(Guid guid);
    void UpdateShippingMethod(ShippingMethod shippingmethod);
    void RemoveShippingMethodByGuid(Guid guid);
}