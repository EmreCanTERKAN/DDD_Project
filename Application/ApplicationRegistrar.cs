using Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;
public static class ApplicationRegistrar 
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly(),typeof(Entity).Assembly);
        });
        return services;
    }
}
