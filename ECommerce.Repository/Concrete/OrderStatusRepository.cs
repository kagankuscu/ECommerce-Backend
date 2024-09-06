using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class OrderStatusRepository : Repository<OrderStatus>, IOrderStatusRepository
{
    public OrderStatusRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddOrderStatus(OrderStatus orderstatus) => Add(orderstatus);

    public async Task<OrderStatus?> GetOrderStatusByGuidAsync(Guid guid) => await GetAll(orderstatus => orderstatus.Guid == guid).SingleOrDefaultAsync();

    public async Task<OrderStatus?> GetOrderStatusByIdAsync(int id) => await GetAll(orderstatus => orderstatus.Id == id).SingleOrDefaultAsync();

    public async Task<List<OrderStatus>> GetAllOrderStatusesAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveOrderStatusByGuid(Guid guid) => Remove(guid);

    public void UpdateOrderStatus(OrderStatus orderstatus) => Update(orderstatus);
}