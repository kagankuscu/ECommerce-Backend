using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IOrderStatusService
{
    void AddOrderStatus(OrderStatus orderstatus);
    Task<List<OrderStatus>> GetAllOrderStatusesAsync();
    Task<OrderStatus?> GetOrderStatusByIdAsync(int id);
    Task<OrderStatus?> GetOrderStatusByGuidAsync(Guid guid);
    void UpdateOrderStatus(OrderStatus orderstatus);
    void RemoveOrderStatusByGuid(Guid guid);
}