using System.Reflection;
using System.Runtime.CompilerServices;
using ECommerce.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Business.Configuration;

public static class BusinessExtension
{
    public static void AddRepository(this IServiceCollection service)
    {
        var types = Assembly.GetAssembly(typeof(RepositoryAssembly))!
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && !t.IsInterface)
            .Where(t => !t.IsNested && !t.IsGenericType && !t.Name.Contains("Assembly"));

        foreach (var type in types)
        {
            var interfaceRepository = type
                .GetInterfaces()
                .Where(t => !t.Name.Contains("IRepository"))
                .SingleOrDefault();

            if (interfaceRepository is not null)
                service.AddScoped(interfaceRepository, type);
        }
    }
    public static void AddBusiness(this IServiceCollection service)
    {
        var types = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.IsClass && !x.IsAbstract && !x.IsInterface && !IsCompilerGenerated(x))
            .Where(x => !x.Name.Contains("Configuration"));

        foreach (var type in types)
        {
            var interfaceService = type.GetInterfaces().SingleOrDefault();
            if (interfaceService is not null)
                service.AddScoped(interfaceService, type);
        }
    }
    private static bool IsCompilerGenerated(Type type)
    {
        return type.Name.Contains('<') || type.GetCustomAttributes(typeof(CompilerGeneratedAttribute), false).Any();
    }
}
