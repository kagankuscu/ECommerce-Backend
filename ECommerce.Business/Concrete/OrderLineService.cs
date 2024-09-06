using ECommerce.Business.Abstract;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;

namespace ECommerce.Business.Concrete;

public class OrderLineService : IOrderLineService
{
    private readonly IOrderLineRepository _repository;

    public OrderLineService(IOrderLineRepository repository)
    {
        _repository = repository;
    }

    public void AddOrderLine(OrderLine orderline) => _repository.AddOrderLine(orderline);

    public async Task<OrderLine?> GetOrderLineByGuidAsync(Guid guid) => await _repository.GetOrderLineByGuidAsync(guid);

    public async Task<OrderLine?> GetOrderLineByIdAsync(int id) => await _repository.GetOrderLineByIdAsync(id);

    public async Task<List<OrderLine>> GetAllOrderLinesAsync() => await _repository.GetAllOrderLinesAsync();

    public void RemoveOrderLineByGuid(Guid guid) => _repository.RemoveOrderLineByGuid(guid);

    public void UpdateOrderLine(OrderLine orderline) => _repository.UpdateOrderLine(orderline);
}
