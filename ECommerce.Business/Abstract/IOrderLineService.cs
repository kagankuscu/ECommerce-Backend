using ECommerce.Models.Models;

namespace ECommerce.Business.Abstract;

public interface IOrderLineService
{
    void AddOrderLine(OrderLine orderline);
    Task<List<OrderLine>> GetAllOrderLinesAsync();
    Task<OrderLine?> GetOrderLineByIdAsync(int id);
    Task<OrderLine?> GetOrderLineByGuidAsync(Guid guid);
    void UpdateOrderLine(OrderLine orderline);
    void RemoveOrderLineByGuid(Guid guid);
}