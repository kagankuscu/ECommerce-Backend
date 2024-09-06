using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Abstract;
using ECommerce.Repository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Concrete;

public class PaymentTypeRepository : Repository<PaymentType>, IPaymentTypeRepository
{
    public PaymentTypeRepository(ApplicationDbContext context) : base(context)
    {
    }

    public void AddPaymentType(PaymentType paymenttype) => Add(paymenttype);

    public async Task<PaymentType?> GetPaymentTypeByGuidAsync(Guid guid) => await GetAll(paymenttype => paymenttype.Guid == guid).SingleOrDefaultAsync();

    public async Task<PaymentType?> GetPaymentTypeByIdAsync(int id) => await GetAll(paymenttype => paymenttype.Id == id).SingleOrDefaultAsync();

    public async Task<List<PaymentType>> GetAllPaymentTypesAsync() => await GetAll().AsNoTracking().ToListAsync();

    public void RemovePaymentTypeByGuid(Guid guid) => Remove(guid);

    public void UpdatePaymentType(PaymentType paymenttype) => Update(paymenttype);
}