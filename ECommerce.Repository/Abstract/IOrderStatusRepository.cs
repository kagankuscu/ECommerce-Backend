using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IOrderStatusRepository : IRepository<OrderStatus>
{
    void AddOrderStatus(OrderStatus orderstatus);
    Task<List<OrderStatus>> GetAllOrderStatusesAsync();
    Task<OrderStatus?> GetOrderStatusByIdAsync(int id);
    Task<OrderStatus?> GetOrderStatusByGuidAsync(Guid guid);
    void UpdateOrderStatus(OrderStatus orderstatus);
    void RemoveOrderStatusByGuid(Guid guid);
}