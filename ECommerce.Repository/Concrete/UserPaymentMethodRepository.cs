using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class UserPaymentMethodRepository : Repository<UserPaymentMethod>, IUserPaymentMethodRepository
{
    public UserPaymentMethodRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddUserPaymentMethod(UserPaymentMethod userpaymentmethod) => Add(userpaymentmethod);

    public async Task<UserPaymentMethod?> GetUserPaymentMethodByGuidAsync(Guid guid) => await GetAll(userpaymentmethod => userpaymentmethod.Guid == guid).SingleOrDefaultAsync();

    public async Task<UserPaymentMethod?> GetUserPaymentMethodByIdAsync(int id) => await GetAll(userpaymentmethod => userpaymentmethod.Id == id).SingleOrDefaultAsync();

    public async Task<List<UserPaymentMethod>> GetAllUserPaymentMethodsAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemoveUserPaymentMethodByGuid(Guid guid) => Remove(guid);

    public void UpdateUserPaymentMethod(UserPaymentMethod userpaymentmethod) => Update(userpaymentmethod);
}