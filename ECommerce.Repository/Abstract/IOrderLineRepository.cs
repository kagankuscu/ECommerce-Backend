using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;

namespace ECommerce.Repository.Abstract;

public interface IOrderLineRepository : IRepository<OrderLine>
{
    void AddOrderLine(OrderLine orderline);
    Task<List<OrderLine>> GetAllOrderLinesAsync();
    Task<OrderLine?> GetOrderLineByIdAsync(int id);
    Task<OrderLine?> GetOrderLineByGuidAsync(Guid guid);
    void UpdateOrderLine(OrderLine orderline);
    void RemoveOrderLineByGuid(Guid guid);
}