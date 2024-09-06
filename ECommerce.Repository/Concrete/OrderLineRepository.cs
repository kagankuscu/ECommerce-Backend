using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class OrderLineRepository : Repository<OrderLine>, IOrderLineRepository
{
    public OrderLineRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddOrderLine(OrderLine orderline) => Add(orderline);

    public async Task<OrderLine?> GetOrderLineByGuidAsync(Guid guid) => await GetAll(orderline => orderline.Guid == guid).SingleOrDefaultAsync();

    public async Task<OrderLine?> GetOrderLineByIdAsync(int id) => await GetAll(orderline => orderline.Id == id).SingleOrDefaultAsync();

    public async Task<List<OrderLine>> GetAllOrderLinesAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveOrderLineByGuid(Guid guid) => Remove(guid);

    public void UpdateOrderLine(OrderLine orderline) => Update(orderline);
}