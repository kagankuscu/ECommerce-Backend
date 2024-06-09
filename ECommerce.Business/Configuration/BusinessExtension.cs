using ECommerce.Repository.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Business.Configuration;

public static class BusinessExtension
{
    public static void AddRepository(this IServiceCollection service)
    {
        service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
