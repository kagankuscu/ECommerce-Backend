using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class OrderStatusService : IOrderStatusService
{
    private readonly IOrderStatusRepository _repository;

    public OrderStatusService(IOrderStatusRepository repository)
    {
        _repository = repository;
    }

    public void AddOrderStatus(OrderStatus orderstatus) => _repository.AddOrderStatus(orderstatus);

    public async Task<OrderStatus?> GetOrderStatusByGuidAsync(Guid guid) => await _repository.GetOrderStatusByGuidAsync(guid);

    public async Task<OrderStatus?> GetOrderStatusByIdAsync(int id) => await _repository.GetOrderStatusByIdAsync(id);

    public async Task<List<OrderStatus>> GetAllOrderStatusesAsync() => await _repository.GetAllOrderStatusesAsync();

    public void RemoveOrderStatusByGuid(Guid guid) => _repository.RemoveOrderStatusByGuid(guid);

    public void UpdateOrderStatus(OrderStatus orderstatus) => _repository.UpdateOrderStatus(orderstatus);
}
